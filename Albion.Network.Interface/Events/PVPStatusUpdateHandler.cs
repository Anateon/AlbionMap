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
    public class PVPStatusUpdateHandler : EventPacketHandler<PVPStatusUpdateEvent>
    {

        public PVPStatusUpdateHandler() : base(EventCodes.PVPStatus)
        {
        }

        protected override Task OnActionAsync(PVPStatusUpdateEvent value)
        {
            try
            {
                //MainWindow.mutexObj.WaitOne();
                if (MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    if (value.PVPmode && MainWindow.needPVPNewPlayerSound)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                    }
                    ((PlayerInfo)MainWindow.chelDictionary[value.Id]).PvpMode = value.PVPmode;
                    MainWindow.chelDictionary[value.Id].NeedUpdate = true;

                }
                //MainWindow.mutexObj.ReleaseMutex();

            }
            catch (Exception)
            {
                //Console.WriteLine("error LeaveEventHandler:" + exception.Message);

            }
            return Task.CompletedTask;
        }
    }
}
