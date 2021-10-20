using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class FishingMiniGameEventHandler : EventPacketHandler<FishingMiniGameEvent>
    {
        public FishingMiniGameEventHandler() : base(EventCodes.FishingMiniGame) { }

        protected override Task OnActionAsync(FishingMiniGameEvent value)
        {
            try
            {
                var tmp = new ResurseInfo()
                {
                    X = value.Position[0],
                    Y = value.Position[1],
                    Nuber = value.Status,
                    Type = HarvestableTypeResource.FISH,
                    Leave = false,
                    Time = DateTime.Now,
                    Lvl = -2,
                    NeedUpdate = true,
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
