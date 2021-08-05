using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class NewMobEvent : BaseEvent
    {
        public NewMobEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 13 и 14 это ХП
            Id = parameters[0].ToString();
            Position = (float[])parameters[7];
            FullHP = parameters.TryGetValue(13, out object hp) ? Int32.Parse(hp.ToString()) : 0;
            //parameters.TryGetValue(19, out object hp2) ? hp2.ToString() : null
        }

        public string Id { get; }
        public float[] Position { get; }
        //public string NowHP { get; }
        public int FullHP { get; }

    }
}
