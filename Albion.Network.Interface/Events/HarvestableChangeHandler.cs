using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class HarvestableChangeHandler : EventPacketHandler<HarvestableChangeEvent>
    {
        public HarvestableChangeHandler() : base(EventCodes.HarvestableChangeState) { }

        protected override Task OnActionAsync(HarvestableChangeEvent value)
        {
            try
            {
                ResurseInfo tmp = (ResurseInfo)MainWindow.chelDictionary[value.Id];
                tmp.Nuber = value.Numer;
                tmp.NeedUpdate = true;
                tmp.Leave = false;
                tmp.Time = DateTime.Now;
                MainWindow.mutexObj.WaitOne();
                MainWindow.chelDictionary[value.Id] = tmp;
                MainWindow.mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
                throw;
            }
            return Task.CompletedTask;
        }
    }
}
