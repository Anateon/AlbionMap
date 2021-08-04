using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
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
        public static Dictionary<string, ChelInfo> chelDictionary = new Dictionary<string, ChelInfo>();
        public static ChelInfo MyInfo = new ChelInfo();
        public static Mutex mutexObj = new Mutex();
        private System.Windows.Threading.DispatcherTimer dispatcherTimer;
        private double scale = 9;
        private static List<Thread> threads = new List<Thread>();
        private static int secondsToDell = 10;
        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0,1);
            dispatcherTimer.Start();


            ReceiverBuilder builder = ReceiverBuilder.Create();
            
            builder.AddRequestHandler(new MoveRequestHandler()); // мое перемещение
            builder.AddEventHandler(new MoveEventHandler()); // Движения типов 
            builder.AddEventHandler(new NewCharacterEventHandler()); //новые типы
            //builder.AddEventHandler(new NewMobEventHandler()); // новые мобы
            
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
            mutexObj.WaitOne();
            try
            {
                foreach (KeyValuePair<String, ChelInfo> pairForDel in chelDictionary.ToArray())
                {
                    if (pairForDel.Value.time < timeNow)// если надо убрать старых челов
                    {
                        foreach (Ellipse pointsChild in Points.Children)
                        {
                            if (pointsChild.Name == $"ID{pairForDel.Key}")
                            {
                                Points.Children.Remove(pointsChild);
                                break;
                            }
                        }
                        chelDictionary.Remove(pairForDel.Key);
                    }
                }

                foreach (KeyValuePair<String, ChelInfo> pairForUpdate in chelDictionary)
                {
                    bool newPoint = true;
                    for (int i = 0; i < Points.Children.Count; i++)
                    {
                        if (((Ellipse)Points.Children[i]).Name == $"ID{pairForUpdate.Key}")
                        {
                            newPoint = false;
                            ((Ellipse)Points.Children[i]).Margin = new Thickness((pairForUpdate.Value.X - MyInfo.X) * scale, 0, 0, (pairForUpdate.Value.Y - MyInfo.Y) * scale);
                            break;
                        }
                    }

                    if (newPoint)
                    {
                        var elipse = 
                        Points.Children.Add(new Ellipse()
                        {
                            Fill = Brushes.Red,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            Height = 7,
                            Width = 7,
                            Margin = new Thickness((pairForUpdate.Value.X - MyInfo.X) * scale, 0, 0, (pairForUpdate.Value.Y - MyInfo.Y) * scale),
                            Stroke = Brushes.Black,
                            Name = $"ID{pairForUpdate.Key}",
                            Opacity = 0.5
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("error:" + exception.Message);
                throw;
                //Points.Children.RemoveRange(0,Int32.MaxValue);
            }
            mutexObj.ReleaseMutex();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
