using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public class NewChatacterEventHandler : EventPacketHandler<NewCharacterEvent>
    {

        public NewChatacterEventHandler() : base(EventCodes.NewCharacter)
        {
        }

        protected override Task OnActionAsync(NewCharacterEvent value)
        {
            try
            {
                if (MainWindow.needPVPNewPlayerSound && value.PVPmode)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                }
                else if (MainWindow.needNewPlayerSound)
                {
                    //using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Windows Ringin.wav"))
                    //{
                    //    soundPlayer.Play();
                    //}

                    System.Media.SystemSounds.Beep.Play();
                    //new Thread(() => Console.Beep()).Start();
                }

                var tmp = new PlayerInfo()
                {
                    //name = value.Name,
                    X = value.Position[0],
                    Y = value.Position[1],
                    Leave = false,
                    Time = DateTime.Now,
                    NowHP = value.NowHP,
                    FullHP = value.FullHP,
                    Name = value.Name,
                    NeedUpdate = true,
                    PvpMode = value.PVPmode
                };
                MainWindow.mutexObj.WaitOne();
                MainWindow.chelDictionary[value.Id] = tmp;
                MainWindow.mutexObj.ReleaseMutex();
                //Console.WriteLine($"New ch Id: {value.Id} name: {value.Name} hp: {value.FullHP}/{value.NowHP}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("error NewCharacterEventHandler:" + exception.Message);
                throw;

            }
            return Task.CompletedTask;
        }
    }
}
