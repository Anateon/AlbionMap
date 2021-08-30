using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class NewFishingZoneObjectEvent : BaseEvent
    {
        public NewFishingZoneObjectEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
            Position = (float[])parameters[1];
            Number = parameters.TryGetValue(2, out object var) ? int.Parse(var.ToString()) : 0;
            if ((parameters.TryGetValue(4, out object var1) ? (var1.ToString()) : "") == "")
            {
                Lvl = -1;
            }
            else
            {
                Lvl = 0;
            }
        }
        public int Id { get; }
        public float[] Position { get; }
        public int Number { get; }
        public int Lvl { get; }

    }
}
