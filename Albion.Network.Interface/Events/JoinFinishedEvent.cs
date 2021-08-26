using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class JoinFinishedEvent : BaseEvent
    {
        public JoinFinishedEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 13 и 14 это ХП
        }

    }
}
