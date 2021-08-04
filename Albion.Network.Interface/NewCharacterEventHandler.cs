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
    public class NewCharacterEventHandler : EventPacketHandler<NewCharacterEvent>
    {

        public NewCharacterEventHandler() : base(EventCodes.NewCharacter)
        {
        }

        protected override Task OnActionAsync(NewCharacterEvent value)
        {
            try
            {
                MainWindow.mutexObj.WaitOne();
                if (!MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Windows Ringin.wav"))
                    {
                        soundPlayer.Play();
                    }

                }
                MainWindow.chelDictionary[value.Id] = new ChelInfo()
                {
                    name = value.Name,
                    X = value.Position[0],
                    Y = value.Position[1],
                    time = DateTime.Now
                };
                MainWindow.mutexObj.ReleaseMutex();
                //Console.WriteLine($"New ch Id: {value.Id} name: {value.Name} hp: {value.FullHP}/{value.NowHP}");
            }
            catch (Exception e)
            {
            }
            return Task.CompletedTask;
        }
    }
}
