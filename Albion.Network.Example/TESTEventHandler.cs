using System;
using System.Collections.Generic;
using System.Media;
using System.Threading.Tasks;

namespace Albion.Network.Example
{
    public class TESTEventHandler : EventPacketHandler<TESTEvent>
    {
        public Dictionary<string, ChelInfo> cheliki;

        public TESTEventHandler() : base(EventCodes.NewCharacter)
        {
        }

        protected override Task OnActionAsync(TESTEvent value)
        {
            return Task.CompletedTask;
        }
    }
}
