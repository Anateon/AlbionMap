using System;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class JoinFinishedEventHandler : EventPacketHandler<JoinFinishedEvent>
    {
        public JoinFinishedEventHandler() : base(EventCodes.JoinFinished) { }

        protected override Task OnActionAsync(JoinFinishedEvent value)
        {
            MainWindow.mutexObj.WaitOne();
            foreach (var var in MainWindow.chelDictionary)
            {
                if (!(var.Value is PlayerInfo))
                {
                    MainWindow.chelDictionary[var.Key].Leave = true;
                }

                MainWindow.ZIndexCounter = 15000;
            }
            MainWindow.mutexObj.ReleaseMutex();
            return Task.CompletedTask;
        }
    }
}
