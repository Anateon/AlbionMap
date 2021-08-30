using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class HarvestableChangeEvent : BaseEvent
    {
        public HarvestableChangeEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
            Numer = parameters.TryGetValue(1, out object var) ? int.Parse(var.ToString()) : 0;
            //(int)(parameters.TryGetValue(3, out object var) ? int.Parse(var.ToString()) : 0)
        }

        public int Id { get; }
        public int Numer { get; }

    }
}
