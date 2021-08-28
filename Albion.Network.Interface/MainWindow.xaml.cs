using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Albion.Network.Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static IPhotonReceiver receiver;
        public static Dictionary<int, ObjectInfo> chelDictionary = new Dictionary<int, ObjectInfo>();
        public static List<int> keysForDell = new List<int>();
        public static PlayerInfo MyInfo = new PlayerInfo();
        public static Mutex mutexObj = new Mutex();
        private DispatcherTimer dispatcherTimer;
        private static List<Thread> threads = new List<Thread>();
        public static bool fullSizeStatus = false;
        public static int ZIndexCounter = 15000;

        public HotKey hotKeyFullSizeMode;
        public HotKey hotKeyPlusSize;
        public HotKey hotKeyMinusSize;

        #region cfg
        public static bool needNewPlayerSound = false;
        public static bool needPVPNewPlayerSound = true;
        private static int secondsToDell = 10;
        public static double scale = 9;
        public static bool needHPProcent = true;
        public static bool needHPValuve = true;
        public static bool needNickname = true;
        public static int moobNeedHP = 0;
        public static bool needHideZeroResouse = true;
        public static bool needResourseCaption = true;
        public static int tierFileter = 0;
        public static int lvlFilter = 0;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0,250);
            dispatcherTimer.Start();

            PointsControll.radarArea = Points;
            ReceiverBuilder builder = ReceiverBuilder.Create();
            
            builder.AddRequestHandler(new MoveRequestHandler()); // мое перемещение
            builder.AddEventHandler(new MoveEventHandler()); // Движения типов 
            builder.AddEventHandler(new NewChatacterEventHandler()); //новые типы
            builder.AddEventHandler(new NewMobEventHandler()); // новые мобы
            builder.AddEventHandler(new LeaveEventHandler()); // Исчезновеня типов
            builder.AddEventHandler(new HealthUpdateEventHandler()); // изменения ХП
            builder.AddEventHandler(new PVPStatusUpdateHandler()); // если чел врубил ПВП режим
            builder.AddEventHandler(new NewResuseEventHandler()); // для ресурсов
            builder.AddEventHandler(new TierMobEventHandler()); // для тира ресурсов
            builder.AddEventHandler(new JoinFinishedEventHandler()); // для перехода между локами
            builder.AddEventHandler(new NewSimpleHarvestableObjectListEventHandler()); // для отслеживания деревьев/камня
            hotKeyFullSizeMode = new HotKey(Key.M, HotKey.KeyModifier.Alt, (HotKey o) =>
            {
                if (fullSizeStatus)
                {
                    fullSizeStatus = false;
                    WindowState = WindowState.Normal;
                    IntPtr hwnd = new WindowInteropHelper(this).Handle;
                    Win32.makeNormal(hwnd);
                    //TabControl.Background = Brushes.White;
                    SliderOpacity.Value = 0.74;
                    SliderOpacity.Value = 0.75;
                    TabItem1.Visibility = Visibility.Visible;
                    TabItem2.Visibility = Visibility.Visible;
                }
                else
                {
                    fullSizeStatus = true;
                    WindowState = WindowState.Maximized;
                    IntPtr hwnd = new WindowInteropHelper(this).Handle;
                    Win32.makeTransparent(hwnd);
                    //TabControl.Background = Brushes.Transparent;
                    MainGrid.Background = Brushes.Transparent;
                    TabItem1.Visibility = Visibility.Hidden;
                    TabItem2.Visibility = Visibility.Hidden;
                }
            });
            hotKeyMinusSize = new HotKey(Key.OemMinus, HotKey.KeyModifier.Alt, (HotKey o) =>
            {
                int tmp = int.Parse(Scale.Text);
                tmp--;
                if (tmp < 0)
                {
                    tmp = 0;
                }
                Scale.Text = tmp.ToString();
            });

            hotKeyPlusSize = new HotKey(Key.OemPlus, HotKey.KeyModifier.Alt, (HotKey o) =>
            {
                int tmp = int.Parse(Scale.Text);
                tmp++;
                Scale.Text = tmp.ToString();
            });

            receiver = builder.Build();

            Console.WriteLine("Start");

            CaptureDeviceList devices = CaptureDeviceList.Instance;
            foreach (var device in devices)
            {
                threads.Add(new Thread(() =>
                {
                    Console.WriteLine($"Open... {device.Description}");
                    if (device.Description.Contains("Realtek"))
                    {
                        Console.Write("Realtek ADD");
                        device.OnPacketArrival += new PacketArrivalEventHandler(PacketHandler);
                        device.Open(DeviceMode.Promiscuous, 1000);
                        device.StartCapture();
                    }
                }));
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

        }
        private static void PacketHandler(object sender, CaptureEventArgs e)
        {
            UdpPacket packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data).Extract<UdpPacket>();
            if (packet != null && (packet.SourcePort == 5056 || packet.DestinationPort == 5056))
            {
                receiver.ReceivePacket(packet.PayloadData);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var timeNow = DateTime.Now.AddSeconds(secondsToDell*-1);
            keysForDell.Clear();
            //try
            //{
                foreach (KeyValuePair<int, ObjectInfo> pairForDel in chelDictionary.ToArray())
                {
                    if (pairForDel.Value is ResurseInfo)
                    {
                        if (pairForDel.Value.Leave && pairForDel.Value.Time < timeNow)// если надо убрать старых челов
                        {
                            keysForDell.Add(pairForDel.Key);
                            mutexObj.WaitOne();
                            chelDictionary.Remove(pairForDel.Key);
                            mutexObj.ReleaseMutex();
                        }
                        else if (!pairForDel.Value.Leave)
                        {
                            if (Math.Sqrt(Math.Pow(pairForDel.Value.X - MyInfo.X, 2) + Math.Pow(pairForDel.Value.Y - MyInfo.Y, 2)) > 150)
                            {
                                pairForDel.Value.Leave = true;
                            }
                        }
                    }
                    else
                    {
                        if (pairForDel.Value.Leave && pairForDel.Value.Time < timeNow)// если надо убрать старых челов
                        {
                            keysForDell.Add(pairForDel.Key);
                            mutexObj.WaitOne();
                            chelDictionary.Remove(pairForDel.Key);
                            mutexObj.ReleaseMutex();
                        }
                    }
                }

                foreach (var pairforDel in keysForDell)
                {
                    PointsControll.DelPoint(pairforDel);
                }
                foreach (KeyValuePair<int, ObjectInfo> pairForUpdate in chelDictionary.ToArray())
                {
                    if (pairForUpdate.Value.NeedUpdate || MyInfo.NeedUpdate)
                    {
                        chelDictionary[pairForUpdate.Key].NeedUpdate = false; 
                        PointsControll.UpdatePoints(pairForUpdate);
                    }
                }
                MyInfo.NeedUpdate = false;
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine("error:" + exception.Message);
            //    throw;
            //    //Points.Children.RemoveRange(0,Int32.MaxValue);
            //}
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void CheckBox_Radar(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked)
            {
                dispatcherTimer.Start();
            }
            else
            {
                dispatcherTimer.Stop();
            }
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            mutexObj.WaitOne();
            e.Handled = !e.Text.All((c) => { return char.IsNumber(c); });
            mutexObj.ReleaseMutex();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            secondsToDell = Int32.Parse(((TextBox)sender).Text);
            mutexObj.ReleaseMutex();

        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            scale = Int32.Parse(((TextBox)sender).Text);
            MyInfo.NeedUpdate = true;
            if (RadiusTextBox != null)
            {
                TextBox_TextChanged3(RadiusTextBox, null);
            }
            mutexObj.ReleaseMutex();
        }

        private void TextBox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            int z;
            try
            {
                z = Int32.Parse(((TextBox) sender).Text);
                if (z == 0)
                {
                    ShowRadius.Visibility = Visibility.Hidden;
                }
                else
                {
                    ShowRadius.Visibility = Visibility.Visible;
                    ShowRadius.Width = ShowRadius.Height = z * scale;
                }
            }
            catch (Exception exception)
            {
                ShowRadius.Visibility = Visibility.Hidden;
            }
        }

        private void CheckBox_SoundNotification(object sender, RoutedEventArgs e)
        {
            needNewPlayerSound = (bool)((CheckBox)sender).IsChecked;
        }

        private void CheckBox_PVPSoundNotification(object sender, RoutedEventArgs e)
        {
            needPVPNewPlayerSound = (bool)((CheckBox)sender).IsChecked;
        }

        private void TextBox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            moobNeedHP = Int32.Parse(((TextBox)sender).Text);
            mutexObj.ReleaseMutex();
        }

        private void CheckBox_HPValuve(object sender, RoutedEventArgs e)
        {
            needHPValuve = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_HPProcent(object sender, RoutedEventArgs e)
        {
            needHPProcent = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;

        }

        private void CheckBox_Nickname(object sender, RoutedEventArgs e)
        {
            needNickname = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            needResourseCaption = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            needHideZeroResouse = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }
        private void TextBox_TextChanged5(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            tierFileter = Int32.Parse(((TextBox)sender).Text);
            mutexObj.ReleaseMutex();
        }
        private void TextBox_TextChanged6(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            lvlFilter = Int32.Parse(((TextBox)sender).Text);
            mutexObj.ReleaseMutex();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TabItem1.Opacity = TabItem2.Opacity = e.NewValue;
            MainGrid.Background = new SolidColorBrush(new Color() {A = (byte)(e.NewValue*255), R = 255, G = 255, B = 255});
        }
        private void Slider_ValueChanged1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Width = e.NewValue;
            Height = Width + 22;
            WindowState = WindowState.Normal;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedIndex = 0;
            IntPtr hwnd = new WindowInteropHelper(this).Handle;
            Win32.makeTransparent(hwnd);
        }
    }
}
