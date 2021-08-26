using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class TierMobEvent : BaseEvent
    {
        public TierMobEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
            tier = int.Parse(parameters[1].ToString());
        }

        public int Id { get; }
        public int tier { get; }

    }
}
