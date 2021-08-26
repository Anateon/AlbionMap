using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public class ChangeClusterRequestHandler : RequestPacketHandler<ChangeClusterOperation>
    {

        public ChangeClusterRequestHandler() : base(OperationCodes.ChangeCluster)
        {
        }

        protected override Task OnActionAsync(ChangeClusterOperation value)
        {
            try
            {
                //MainWindow.mutexObj.WaitOne();
                MainWindow.MyInfo.X = value.Position[0];
                MainWindow.MyInfo.Y = value.Position[1];
                MainWindow.MyInfo.NeedUpdate = true;
                //MainWindow.mutexObj.ReleaseMutex();
            }
            catch (Exception exception)
            {
                Console.WriteLine("error MoveRequestHandler:" + exception.Message);
                throw;
            }

            return Task.CompletedTask;
        }
    }
}
