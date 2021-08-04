using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0,100);
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
            try
            {
                var timeNow = DateTime.Now.AddMinutes(-1);
                // Updating the Label which displays the current second
                mutexObj.WaitOne();
                foreach (KeyValuePair<String, ChelInfo> keyValuePair in chelDictionary)
                {
                    if (keyValuePair.Value.time < timeNow)// если надо убрать старых челов
                    {
                        foreach (Ellipse pointsChild in Points.Children)
                        {
                            if (pointsChild.Name == $"ID{keyValuePair.Key}")
                            {
                                Points.Children.Remove(pointsChild);
                                break;
                            }
                        }
                        chelDictionary.Remove(keyValuePair.Key);
                    }
                    else
                    {
                        bool newPoint = true;
                        for (int i = 0; i < Points.Children.Count; i++)
                        {
                            if (((Ellipse)Points.Children[i]).Name == $"ID{keyValuePair.Key}")
                            {
                                newPoint = false;
                                ((Ellipse)Points.Children[i]).Margin = new Thickness((keyValuePair.Value.X - MyInfo.X) * scale, 0, 0, (keyValuePair.Value.Y - MyInfo.Y) * scale);
                                break;
                            }
                        }

                        if (newPoint)
                        {
                            Points.Children.Add(new Ellipse()
                            {
                                Fill = Brushes.Red,
                                HorizontalAlignment = HorizontalAlignment.Center,
                                VerticalAlignment = VerticalAlignment.Center,
                                Height = 7,
                                Width = 7,
                                Margin = new Thickness((keyValuePair.Value.X - MyInfo.X) * scale, 0, 0, (keyValuePair.Value.Y - MyInfo.Y) * scale),
                                Stroke = Brushes.Black,
                                Name = $"ID{keyValuePair.Key}",
                                Opacity = 0.5
                            });
                        }
                    }
                }
                mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
