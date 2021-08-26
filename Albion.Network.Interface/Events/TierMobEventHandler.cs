using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class TierMobEventHandler : EventPacketHandler<TierMobEvent>
    {
        public TierMobEventHandler() : base(EventCodes.HarvestableChangeState) { }

        protected override Task OnActionAsync(TierMobEvent value)
        {
            try
            {
                MobInfo tmp = (MobInfo)MainWindow.chelDictionary[value.Id];
                tmp.Tier = value.tier;
                tmp.NeedUpdate = true;
                tmp.time = DateTime.Now;
                MainWindow.mutexObj.WaitOne();
                MainWindow.chelDictionary[value.Id] = tmp;
                MainWindow.mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
                Console.WriteLine("error NewMobEventHandler:" + exception.Message);
                throw;
            }
            return Task.CompletedTask;
        }
    }
}
