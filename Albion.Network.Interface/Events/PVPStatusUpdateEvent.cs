using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Albion.Network.Interface
{
    public class PVPStatusUpdateEvent : BaseEvent
    {
        public PVPStatusUpdateEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
            int pvpTmp = parameters.TryGetValue(1, out object pvp) ? Int32.Parse(pvp.ToString()) : 0;
            if (pvpTmp == 0)
                PVPmode = false;
            else
                PVPmode = true;

        }
        public int Id { get; }
        public bool PVPmode { get; }
    }
}
