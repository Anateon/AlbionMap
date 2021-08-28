using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class TEMPLATEEventHandler : EventPacketHandler<TEMPALTEEvent>
    {
        public TEMPLATEEventHandler() : base(999999999) { }

        protected override Task OnActionAsync(TEMPALTEEvent value)
        {
            try
            {
                var tmp = new MobInfo()
                {
                    X = value.Position[0],
                    Y = value.Position[1],
                    Leave = false,
                    Time = DateTime.Now,
                    NowHP = value.NowHP,
                    FullHP = value.FullHP,
                    NeedUpdate = true,
                    Tier = value.tier
                };
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
