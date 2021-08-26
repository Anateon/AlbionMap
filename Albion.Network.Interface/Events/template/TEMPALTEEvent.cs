using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class TEMPALTEEvent : BaseEvent
    {
        public TEMPALTEEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 13 и 14 это ХП
            Id = int.Parse(parameters[0].ToString());
            Position = (float[])parameters[7];
            FullHP = parameters.TryGetValue(13, out object hp1) ? Int32.Parse(hp1.ToString()) : 0;
            NowHP = parameters.TryGetValue(14, out object hp2) ? Int32.Parse(hp2.ToString()) : 0;
            tier = int.Parse(parameters[1].ToString());
        }

        public int Id { get; }
        public float[] Position { get; }
        public int NowHP { get; }
        public int FullHP { get; }
        public int tier { get; }

    }
}
