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
                if (value.type == 23)
                {
                    var tmp = new ResurseInfo()
                    {
                        X = value.Position[0],
                        Y = value.Position[1],
                        leave = false,
                        time = DateTime.Now,
                        NeedUpdate = true,
                        Lvl = value.lvl,
                        nuber = value.kolvo,
                        Tier = value.tier,
                        isAnimal = true
                    };
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
            }
            catch (Exception exception)
            {
                Console.WriteLine("error NewResuseEventHandler:" + exception.Message);
                throw;
            }

            return Task.CompletedTask;
        }
    }
}
