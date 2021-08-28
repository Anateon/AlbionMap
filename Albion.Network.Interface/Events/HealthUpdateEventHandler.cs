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
                //MainWindow.mutexObj.WaitOne();
                if (MainWindow.chelDictionary.ContainsKey(value.Id))
                {
                    //ObjectInfo tmp = MainWindow.chelDictionary[value.Id];
                    //if (MainWindow.chelDictionary[value.Id] is PlayerInfo)
                    //{
                    //    tmp.time = DateTime.Now;
                    //    tmp.leave = false;
                    //    ((PlayerInfo)tmp).NowHP = value.NowHP;
                    //    tmp.NeedUpdate = true;
                    //}
                    //else
                    //{
                    //    tmp.time = DateTime.Now;
                    //    tmp.leave = false;
                    //    ((MobInfo)tmp).NowHP = value.NowHP;
                    //    tmp.NeedUpdate = true;
                    //}
                    ObjectInfo tmp = MainWindow.chelDictionary[value.Id];
                    tmp.Time = DateTime.Now;
                    tmp.Leave = false;
                    ((LifeObject)tmp).NowHP = value.NowHP;
                    tmp.NeedUpdate = true;
                    MainWindow.chelDictionary[value.Id] = tmp;
                }
                //MainWindow.mutexObj.ReleaseMutex();
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
