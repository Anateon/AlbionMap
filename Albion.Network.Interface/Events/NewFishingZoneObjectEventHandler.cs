using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class NewFishingZoneObjectEventHandler : EventPacketHandler<NewFishingZoneObjectEvent>
    {
        public NewFishingZoneObjectEventHandler() : base(EventCodes.NewFishingZoneObject) { }

        protected override Task OnActionAsync(NewFishingZoneObjectEvent value)
        {
            try
            {
                var tmp = new ResurseInfo()
                {
                    X = value.Position[0],
                    Y = value.Position[1],
                    Nuber = value.Number,
                    Type = HarvestableTypeResource.FISH,
                    Leave = false,
                    Lvl = value.Lvl,
                    Time = DateTime.Now,
                    NeedUpdate = true,
                    fishName = value.fishName
                };
                if (value.fishName == "FishingNodeOceanShark")
                {
                    System.Media.SystemSounds.Beep.Play();
                    System.Console.WriteLine($"{tmp.Nuber} FishingNodeOceanShark");
                }
                Console.WriteLine($"{DateTime.Now} '{value.fishName}' {value.Number}");
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
