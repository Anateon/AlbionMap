using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Albion.Network.Interface.BinDumps;
using System.Runtime.Serialization;
using System.Windows.Controls.Primitives;
using System.Xml.Serialization;

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
        private static DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private static List<Thread> threads = new List<Thread>();
        public static Mobs MobsDump;
        public static AOResources ResourcesDump;
        public static bool fullSizeStatus = false;
        public static int ZIndexCounter = 15000;

        public HotKey hotKeyFullSizeMode;
        public HotKey hotKeyPlusSize;
        public HotKey hotKeyMinusSize;

        #region cfg
        public static bool needNewPlayerSound = false;
        public static bool needPVPNewPlayerSound = true;
        private static int secondsToDell = 10;
        public static double scale = 10;
        public static bool needShowPlayerHPProcent = true;
        public static bool needShowPlayerHPValuve = true;
        public static bool needShowNickname = true;
        public static double opacitySaveFullSizeMode;

        public static bool needShowMobHPProcent = true;
        public static bool needShowMobHPValuve = true;
        public static bool needShowMobName = true;

        public static bool needHideZeroResouse = true;
        public static bool needResourseCaption = true;
        public static bool needShowPlayers = true;

        public static List<string> listNames = new List<string>();
        public static byte filterListMode = 0; // 0-off/ 1-white/ 2-black
        #endregion

        #region resursCfg
        public static bool[,] ResurseFilter = new bool[9, 4];
        public static bool needShowFiber;
        public static bool needShowHide;
        public static bool needShowOre;
        public static bool needShowRock;
        public static bool needShowWood;
        public static bool needShowFish;
        public static bool[,] MobFilter = new bool[9, 4];
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0,250);
            dispatcherTimer.Start();

            PointsControll.radarArea = Points;
            ReceiverBuilder builder = ReceiverBuilder.Create();


            // read file into a string and deserialize JSON to a type
            XmlSerializer formatter = new XmlSerializer(typeof(Mobs));
            using (FileStream fs = new FileStream(@"SourseBinDumps\mobs.xml", FileMode.OpenOrCreate))
            {
                MobsDump = (Mobs)formatter.Deserialize(fs);
            }

            foreach (var varMob in MobsDump.Mob)
            {
                ComboBoxMobNameList.Items.Add(varMob.uniquename);
            }
            formatter = new XmlSerializer(typeof(AOResources));
            using (FileStream fs = new FileStream(@"SourseBinDumps\resources.xml", FileMode.OpenOrCreate))
            {
                ResourcesDump = (AOResources)formatter.Deserialize(fs);
            }


            builder.AddRequestHandler(new MoveRequestHandler()); // мое перемещение
            builder.AddEventHandler(new MoveEventHandler()); // Движения типов 
            builder.AddEventHandler(new NewChatacterEventHandler()); //новые типы
            builder.AddEventHandler(new NewMobEventHandler()); // новые мобы
            builder.AddEventHandler(new LeaveEventHandler()); // Исчезновеня типов
            builder.AddEventHandler(new HealthUpdateEventHandler()); // изменения ХП
            builder.AddEventHandler(new PVPStatusUpdateHandler()); // если чел врубил ПВП режим
            builder.AddEventHandler(new NewResuseEventHandler()); // для ресурсов
            builder.AddEventHandler(new HarvestableChangeHandler()); // для тира ресурсов
            builder.AddEventHandler(new JoinFinishedEventHandler()); // для перехода между локами
            builder.AddEventHandler(new NewSimpleHarvestableObjectListEventHandler()); // для отслеживания деревьев/камня
            builder.AddEventHandler(new MobChangeStateEventHandler()); // присваивает тир мобу

             builder.AddEventHandler(new FishingMiniGameEventHandler()); // ЭТО КРЮЧКИ РЫБОЛОВНЫЕ
            builder.AddEventHandler(new NewFishingZoneObjectEventHandler()); // РЫБА


            hotKeyFullSizeMode = new HotKey(Key.M, HotKey.KeyModifier.Alt, (HotKey o) =>
            {
                if (fullSizeStatus)
                {
                    SliderOpacity.Value = 0.1;
                    SliderOpacity.Value = opacitySaveFullSizeMode;
                    fullSizeStatus = false;
                    WindowState = WindowState.Normal;
                    IntPtr hwnd = new WindowInteropHelper(this).Handle;
                    Win32.makeNormal(hwnd);
                    //TabControl.Background = Brushes.White;
                    TabItem1.Visibility = Visibility.Visible;
                    TabItem2.Visibility = Visibility.Visible;
                }
                else
                {
                    opacitySaveFullSizeMode = SliderOpacity.Value;
                    SliderOpacity.Value = 0;
                    TabControl.SelectedIndex = 0;
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
                    device.OnPacketArrival += new PacketArrivalEventHandler(PacketHandler);
                    device.Open(DeviceMode.Promiscuous, 1000);
                    device.StartCapture();
                    //if (device.Description.Contains("Realtek"))
                    //{
                    //    Console.Write("Realtek ADD");

                    //}
                }));
            }
            foreach (var thread in threads)
            {
                thread.Start();
            }
            ConfigStoreRestore(false);
        }
        private static void PacketHandler(object sender, CaptureEventArgs e)
        {
            UdpPacket packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data).Extract<UdpPacket>();
            if (packet != null && (packet.SourcePort == 5056 || packet.DestinationPort == 5056))
            {
                try
                {
                    receiver.ReceivePacket(packet.PayloadData); // ТУТ БЫВАЕТ ОВЕРФЛОУ
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Packet.ParsePacket exception " + exception);
                    //throw;
                }
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
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void CheckBox_Radar(object sender, RoutedEventArgs e)
        {
            if (sender != null)
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
            try
            {
                secondsToDell = Int32.Parse(((TextBox)sender).Text);
            }
            catch (Exception)
            {
                ((TextBox)sender).Text = "0";
                secondsToDell = 0;
            }
            mutexObj.ReleaseMutex();

        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            mutexObj.WaitOne();
            try
            {
                scale = Int32.Parse(((TextBox)sender).Text);
            }
            catch (Exception)
            {
                ((TextBox) sender).Text = "0";
                scale = 0;
            }
            MyInfo.NeedUpdate = true;
            if (RadiusTextBox != null)
            {
                TextBox_TextChanged3(RadiusTextBox, null);
                RadarScaleLable.Text = $"Radar scale ({scale/2}px=1m)";
            }
            mutexObj.ReleaseMutex();
        }

        private void TextBox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            int z;
            try
            {
                try
                {
                    z = Int32.Parse(((TextBox)sender).Text);
                }
                catch (Exception)
                {
                    ((TextBox)sender).Text = "0";
                    z = 0;
                }
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

        private void CheckBox_PlayerHPValuve(object sender, RoutedEventArgs e)
        {
            needShowPlayerHPValuve = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_MobHPValuve(object sender, RoutedEventArgs e)
        {
            needShowMobHPValuve = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_PlayerHPProcent(object sender, RoutedEventArgs e)
        {
            needShowPlayerHPProcent = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_MobHPProcent(object sender, RoutedEventArgs e)
        {
            needShowMobHPProcent = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_Nickname(object sender, RoutedEventArgs e)
        {
            needShowNickname = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBox_MobName(object sender, RoutedEventArgs e)
        {
            needShowMobName = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBoxNeedResourseCaption_Click(object sender, RoutedEventArgs e)
        {
            needResourseCaption = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void CheckBoxneedHideZeroResouse_Click(object sender, RoutedEventArgs e)
        {
            needHideZeroResouse = (bool)((CheckBox)sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (OpacityCaption != null)
            {
                OpacityCaption.Text = $"Opacity ({(int)(e.NewValue * 100)}%)";
            }
            TabItem1.Opacity = TabItem2.Opacity = e.NewValue;
            MainGrid.Background = new SolidColorBrush(new Color() {A = (byte)(e.NewValue*255), R = 255, G = 255, B = 255});
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fullSizeStatus = true;
            TabControl.SelectedIndex = 0;
            IntPtr hwnd = new WindowInteropHelper(this).Handle;
            Win32.makeTransparent(hwnd);
        }

        private void CheckBoxHarvestableAndMob_Click(object sender, RoutedEventArgs e)
        {
            switch (((CheckBox)sender).Name)
            {
                case "CheckBoxFiber":
                    needShowFiber = (bool)((CheckBox) sender).IsChecked;
                    break;
                case "CheckBoxHide":
                    needShowHide = (bool)((CheckBox)sender).IsChecked;
                    break;
                case "CheckBoxOre":
                    needShowOre = (bool)((CheckBox)sender).IsChecked;
                    break;
                case "CheckBoxRock":
                    needShowRock = (bool)((CheckBox)sender).IsChecked;
                    break;
                case "CheckBoxWood":
                    needShowWood = (bool)((CheckBox)sender).IsChecked;
                    break;
                case "CheckBoxFish":
                    needShowFish = (bool)((CheckBox)sender).IsChecked;
                    break;
            }
            MyInfo.NeedUpdate = true;
        }

        private void CheckBoxHarvestableAndMobTierLvl_Click(object sender, RoutedEventArgs e)
        {
            var str = ((CheckBox)sender).Name;
            int Tier;
            int Lvl;
            //CheckBoxT10
            switch (((CheckBox)sender).Name[8])
            {
                case 'M':
                    Tier = int.Parse(str[12].ToString());
                    Lvl = int.Parse(str[13].ToString());
                    MobFilter[Tier, Lvl] = (bool)((CheckBox)sender).IsChecked;
                    break;
                case 'H':
                    Tier = int.Parse(str[20].ToString());
                    Lvl = int.Parse(str[21].ToString());
                    ResurseFilter[Tier, Lvl] = (bool)((CheckBox)sender).IsChecked;
                    break;
            }
            MyInfo.NeedUpdate = true;
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (WindowState != WindowState.Normal)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            needShowPlayers = (bool)((CheckBox) sender).IsChecked;
            MyInfo.NeedUpdate = true;
        }
        private void ButtonAddList_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxMobNameList.Text != null)
            {
                bool exist = false;
                foreach (var mob in MobsDump.Mob)
                {
                    if (mob.uniquename == ComboBoxMobNameList.Text)
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    MessageBox.Show("Error adding a mob (does not exist)");
                    return;
                }
                if (!WhiteBlackList.Items.Contains($"{ComboBoxMobNameList.Text}"))
                {
                    var z = ComboBoxMobNameList.Text;
                    listNames.Add(z);
                    WhiteBlackList.Items.Add(z);
                }
            }
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxMobNameList.Text != null)
            {
                var z = ComboBoxMobNameList.Text;
                listNames.Remove(z);
                WhiteBlackList.Items.Remove(z);
            }
        }

        private void WhiteBlackList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxMobNameList.SelectedItem = e.AddedItems[0].ToString();
            }
            catch (Exception)
            {
                ((ListBox)sender).SelectedIndex = -1;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Off filterList":
                    filterListMode = 0;
                    break;
                case "WhiteList mode":
                    filterListMode = 1;
                    break;
                case "BlackList mode":
                    filterListMode = 2;
                    break;
            }
            MyInfo.NeedUpdate = true;
        }

        private void Button_EditList(object sender, RoutedEventArgs e)
        {
            TextEditorWindow winDialog = new TextEditorWindow();
            foreach (var varItem in WhiteBlackList.Items)
            {
                winDialog.list.Text += (string)varItem +"\r";
            }
            Topmost = false;
            if (winDialog.ShowDialog() == true)
            {
                listNames.Clear();
                WhiteBlackList.Items.Clear();
                foreach (var mob in winDialog.MobList.Split(';'))
                {
                    if (mob == "")
                        break;
                    bool exist = false;
                    foreach (var dumpMobs in MobsDump.Mob)
                    {
                        if (dumpMobs.uniquename == mob)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        MessageBox.Show($"Error adding a mob '{mob}' (does not exist)");
                        return;
                    }
                    if (!WhiteBlackList.Items.Contains(mob))
                    {
                        listNames.Add(mob);
                        WhiteBlackList.Items.Add(mob);
                    }
                }
            }
            Topmost = true;
        }

        private void ConfigStoreRestore(bool StoreMode)
        {
            /*
             * ContentRadarCfgGrid = CheckBox; Slider; TextBox
             * ContentHarvestableGrid = CheckBox
             * ContentPlayerGrid = CheckBox
             * ContentMobGrid = CheckBox; ListBox
             */
            var GridsForSaveResore = new List<Grid>()
            {
                ContentRadarCfgGrid,
                ContentHarvestableGrid,
                ContentPlayerGrid,
                ContentMobGrid
            };
            string saveString = "";
            string fileName = "saveConfig.cfg";
            if (StoreMode)
            {
                foreach (Grid gridElement in GridsForSaveResore)
                {
                    foreach (FrameworkElement varChild in gridElement.Children)
                    {
                        if (varChild.Name != "")
                        {
                            switch (varChild.GetType().Name)
                            {
                                case "CheckBox":
                                    saveString += $"{varChild.Name}={((CheckBox)varChild).IsChecked}\n";
                                    break;
                                case "Slider":
                                    saveString += $"{varChild.Name}={((Slider)varChild).Value}\n";
                                    break;
                                case "TextBox":
                                    saveString += $"{varChild.Name}={((TextBox)varChild).Text}\n";
                                    break;
                                case "ListBox":
                                    saveString += $"{varChild.Name}=";
                                    foreach (var listBoxItem in ((ListBox)varChild).Items)
                                    {
                                        saveString += listBoxItem.ToString() + ';';
                                    }
                                    saveString += "\n";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }

                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(saveString);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        saveString = sr.ReadToEnd();
                    }
                    var saveSplit = saveString.Split('\n');
                    foreach (Grid gridElement in GridsForSaveResore)
                    {
                        foreach (FrameworkElement varChild in gridElement.Children)
                        {
                            if (varChild.Name != "")
                            {
                                foreach (var oneProperty in saveSplit)
                                {
                                    var onePropertySeparated = oneProperty.Split('=');
                                    if (onePropertySeparated[0] == varChild.Name)
                                    {
                                        switch (varChild.GetType().Name)
                                        {
                                            case "CheckBox":
                                                ((CheckBox)varChild).IsChecked = Boolean.Parse(onePropertySeparated[1]);
                                                break;
                                            case "Slider":
                                                ((Slider)varChild).Value = double.Parse(onePropertySeparated[1]);
                                                break;
                                            case "TextBox":
                                                ((TextBox)varChild).Text = onePropertySeparated[1];
                                                break;
                                            case "ListBox":
                                                var moblistSave = onePropertySeparated[1].Split(';');
                                                foreach (var var in moblistSave)
                                                {
                                                    ((ListBox)varChild).Items.Add(var);
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ConfigStoreRestore(true);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WindowSizeY_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (WindowSizeY != null)
            {
                if (int.Parse(WindowSizeY.Text) != Height) 
                    Height = int.Parse(WindowSizeY.Text);
            }
        }

        private void WindowSizeX_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (WindowSizeX != null)
            {
                if (int.Parse(WindowSizeX.Text) != Width)
                    Width = int.Parse(WindowSizeX.Text);
            }
        }

        private void MainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WindowSizeX.Text = Width.ToString();
            WindowSizeY.Text = Height.ToString();
        }
    }
}
