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
                if (value.FullHP == MainWindow.moobNeedHP || value.FullHP == 0)
                {
                    MainWindow.mutexObj.WaitOne();
                    MainWindow.chelDictionary[value.Id] = new ChelInfo()
                    {
                        isMob = true,
                        X = value.Position[0],
                        Y = value.Position[1],
                        leave = false,
                        time = DateTime.Now
                    };
                    MainWindow.mutexObj.ReleaseMutex();
                }
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
