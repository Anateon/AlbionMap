using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class HealthUpdateEventHandler : EventPacketHandler<HealthUpdateEvent>
    {
        public HealthUpdateEventHandler() : base(EventCodes.Health) { }

        protected override Task OnActionAsync(HealthUpdateEvent value)
        {
            try
            {
                MainWindow.mutexObj.WaitOne();
                if (MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    var tmp = MainWindow.chelDictionary[value.Id];
                    tmp.time = DateTime.Now;
                    tmp.leave = false;
                    tmp.NowHP = value.NowHP;
                    MainWindow.chelDictionary[value.Id] = tmp;
                }
                MainWindow.mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
                Console.WriteLine("error HealthUpdateEventHandler:" + exception.Message);
                throw;
            }
            return Task.CompletedTask;
        }
    }
}
