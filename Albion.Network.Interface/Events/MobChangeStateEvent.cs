using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class MobChangeStateEvent : BaseEvent
    {
        public MobChangeStateEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 13 и 14 это ХП
            Id = int.Parse(parameters[0].ToString());
            Lvl = (int)(parameters.TryGetValue(1, out object var) ? double.Parse(var.ToString()) : 0);
        }

        public int Id { get; }
        public int Lvl { get; }

    }
}
