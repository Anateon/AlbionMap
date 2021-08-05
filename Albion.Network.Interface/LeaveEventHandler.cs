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
            MainWindow.mutexObj.WaitOne();
            try
            {
                MainWindow.chelDictionary[value.Id].leave = true;
            }
            catch (Exception e)
            {
            }
            MainWindow.mutexObj.ReleaseMutex();
            return Task.CompletedTask;
        }
    }
}
