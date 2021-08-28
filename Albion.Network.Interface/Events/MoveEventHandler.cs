using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public class MoveEventHandler : EventPacketHandler<MoveEvent>
    {

        public MoveEventHandler() : base(EventCodes.Move)
        {
        }

        protected override Task OnActionAsync(MoveEvent value)
        {
            try
            {
                //MainWindow.mutexObj.WaitOne();
                if (MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    var tmp = MainWindow.chelDictionary[value.Id];
                    tmp.Time = DateTime.Now;
                    tmp.X = value.Position[0];
                    tmp.Y = value.Position[1];
                    tmp.Leave = false;
                    tmp.NeedUpdate = true;
                    MainWindow.chelDictionary[value.Id] = tmp;
                }
                //MainWindow.mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
                Console.WriteLine("error MoveEventHandler:" + exception.Message);
                throw;
            }
            return Task.CompletedTask;
        }
    }
}
