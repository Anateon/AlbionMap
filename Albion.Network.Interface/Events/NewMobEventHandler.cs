using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class NewMobEventHandler : EventPacketHandler<NewMobEvent>
    {
        public NewMobEventHandler() : base(EventCodes.NewMob) { }

        protected override Task OnActionAsync(NewMobEvent value)
        {
            try
            {
                var tmp = new MobInfo()
                {
                    X = value.Position[0],
                    Y = value.Position[1],
                    ObjectId = value.ObjectId,
                    Tier = value.Tier,
                    Name = value.Name,
                    Leave = false,
                    Lvl = 0,
                    Time = DateTime.Now,
                    NowHP = value.NowHP,
                    FullHP = value.FullHP,
                    NeedUpdate = true
                };
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
