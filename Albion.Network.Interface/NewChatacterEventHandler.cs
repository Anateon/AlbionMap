using System;
using System.Collections.Generic;
using System.Media;
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
                MainWindow.mutexObj.WaitOne();

                if (MainWindow.needSound)
                {
                    using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Windows Ringin.wav"))
                    {
                        soundPlayer.Play();
                    }
                }
                MainWindow.chelDictionary[value.Id] = new ChelInfo()
                {
                    //name = value.Name,
                    isMob = false,
                    X = value.Position[0],
                    Y = value.Position[1],
                    leave = false,
                    time = DateTime.Now,
                    NowHP = value.NowHP,
                    FullHP = value.FullHP,
                    name = value.Name
                };
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
