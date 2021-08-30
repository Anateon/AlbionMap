using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class MobChangeStateEventHandler : EventPacketHandler<MobChangeStateEvent>
    {
        public MobChangeStateEventHandler() : base(EventCodes.MobChangeState) { } // присваивает тир мобу

        protected override Task OnActionAsync(MobChangeStateEvent value)
        {
            try
            {
                var tmp = ((MobInfo)MainWindow.chelDictionary[value.Id]);
                tmp.Lvl = value.Lvl;
                tmp.NeedUpdate = true;
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
