using System;
using System.Media;
using System.Threading.Tasks;
using Albion.Network.Interface;

namespace Albion.Network.Interface
{
    public class JoinFinishedEventHandler : EventPacketHandler<JoinFinishedEvent>
    {
        public JoinFinishedEventHandler() : base(EventCodes.JoinFinished) { }

        protected override Task OnActionAsync(JoinFinishedEvent value)
        {

            return Task.CompletedTask;
        }
    }
}
