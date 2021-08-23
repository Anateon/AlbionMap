using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class HealthUpdateEvent : BaseEvent
    {
        public HealthUpdateEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 13 и 14 это ХП
            Id = int.Parse(parameters[0].ToString());
            NowHP = parameters.TryGetValue(3, out object hp2) ? Int32.Parse(hp2.ToString()) : 0;
        }

        public int Id { get; }
        public int NowHP { get; }

    }
}
