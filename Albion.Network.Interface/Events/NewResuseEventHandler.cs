using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class NewResuseEventHandler : EventPacketHandler<NewResurseEvent>
    {
        public NewResuseEventHandler() : base(EventCodes.NewHarvestableObject) { }

        protected override Task OnActionAsync(NewResurseEvent value)
        {
            try
            {
                var tmp = new ResurseInfo()
                {
                    X = value.Position[0],
                    Y = value.Position[1],
                    Leave = false,
                    Time = DateTime.Now,
                    NeedUpdate = true,
                    Tier = value.lvl,
                    Nuber = value.kolvo,
                    Lvl = value.tier,
                };
                if ((value.type >= 0 && value.type <= 7) || (value.type >= 43 && value.type <= 47))
                {
                    tmp.Type = HarvestableTypeResource.WOOD;
                }
                else if ((value.type >= 8 && value.type <= 15) || (value.type >= 48 && value.type <= 52))
                {
                    tmp.Type = HarvestableTypeResource.ROCK;
                }
                else if ((value.type >= 36 && value.type <= 42) || (value.type >= 63 && value.type <= 67))
                {
                    tmp.Type = HarvestableTypeResource.ORE;
                }
                else if ((value.type >= 22 && value.type <= 35) || (value.type >= 58 && value.type <= 62) || value.type == 68)
                {
                    tmp.Type = HarvestableTypeResource.HIDE;
                }
                else if ((value.type >= 16 && value.type <= 21) || (value.type >= 53 && value.type <= 57))
                {
                    tmp.Type = HarvestableTypeResource.FIBER;
                }

                    MainWindow.mutexObj.WaitOne();
                    MainWindow.chelDictionary[value.Id] = tmp;
                    MainWindow.mutexObj.ReleaseMutex();
                    //switch (value.type)
                    //{
                    //    case 4:
                    //        tmp.isTree = true;
                    //        break;
                    //    case 8:
                    //        tmp.isStone = true;
                    //        break;
                    //    case 23:
                    //        tmp.isAnimal = true;
                    //        break;
                    //}
            }
            catch (Exception exception)
            {
                throw;
            }

            return Task.CompletedTask;
        }
    }
}
