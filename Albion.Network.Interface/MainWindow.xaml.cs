using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static IPhotonReceiver receiver;
        public static Dictionary<int, ChelInfo> chelDictionary = new Dictionary<int, ChelInfo>();
        public static ChelInfo MyInfo = new ChelInfo();
        public static Mutex mutexObj = new Mutex();
        private System.Windows.Threading.DispatcherTimer dispatcherTimer;
        public static double scale = 9;
        private static List<Thread> threads = new List<Thread>();
        private static int secondsToDell = 10;
        public static bool needSound = true;
        public static int moobNeedHP = 0;

        public static bool needHPProcent = true;
        public static bool needHPValuve = true;
        public static bool needNickname = true;

        public static List<int> keysForDell = new List<int>();
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


            receiver = builder.Build();

            Console.WriteLine("Start");

            CaptureDeviceList devices = CaptureDeviceList.Instance;
            foreach (var device in devices)
            {
                threads.Add(new Thread(() =>
                {
                    Console.WriteLine($"Open... {device.Description}");

                    device.OnPacketArrival += new PacketArrivalEventHandler(PacketHandler);
                    device.Open(DeviceMode.Promiscuous, 1000);
                    device.StartCapture();
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
            try
            {
                foreach (KeyValuePair<int, ChelInfo> pairForDel in chelDictionary.ToArray())
                {
                    if (pairForDel.Value.time < timeNow && pairForDel.Value.leave)// если надо убрать старых челов
                    {
                        keysForDell.Add(pairForDel.Key);
                        mutexObj.WaitOne();
                        chelDictionary.Remove(pairForDel.Key);
                        mutexObj.ReleaseMutex();
                    }
                }
                foreach (var pairforDel in keysForDell)
                {
                    PointsControll.DelPoint(pairforDel);
                }
                foreach (KeyValuePair<int, ChelInfo> pairForUpdate in chelDictionary.ToArray())
                {
                    if (pairForUpdate.Value.NeedUpdate || MyInfo.NeedUpdate)
                    {
                        chelDictionary[pairForUpdate.Key].NeedUpdate = false; 
                        PointsControll.UpdatePoints(pairForUpdate);
                    }
                }
                MyInfo.NeedUpdate = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine("error:" + exception.Message);
                throw;
                //Points.Children.RemoveRange(0,Int32.MaxValue);
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mutexObj.WaitOne();
            chelDictionary.Clear();
            Points.Children.RemoveRange(0,Int32.MaxValue);
            mutexObj.ReleaseMutex();
        }

        private void CheckBox_SoundNotification(object sender, RoutedEventArgs e)
        {
            needSound = (bool)((CheckBox)sender).IsChecked;
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
        }

        private void CheckBox_HPProcent(object sender, RoutedEventArgs e)
        {
            needHPProcent = (bool)((CheckBox)sender).IsChecked;
        }

        private void CheckBox_Nickname(object sender, RoutedEventArgs e)
        {
            needNickname = (bool)((CheckBox)sender).IsChecked;
        }
    }
}
