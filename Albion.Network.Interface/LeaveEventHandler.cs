using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public class LeaveEventHandler : EventPacketHandler<LeaveEvent>
    {

        public LeaveEventHandler() : base(EventCodes.Leave)
        {
        }

        protected override Task OnActionAsync(LeaveEvent value)
        {
            try
            {
                MainWindow.mutexObj.WaitOne();
                if (MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    MainWindow.chelDictionary[value.Id].leave = true;
                }
                MainWindow.mutexObj.ReleaseMutex();

            }
            catch (Exception)
            {
                //Console.WriteLine("error LeaveEventHandler:" + exception.Message);

            }
            return Task.CompletedTask;
        }
    }
}
