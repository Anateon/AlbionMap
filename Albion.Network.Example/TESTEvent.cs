using System;
using System.Collections.Generic;

namespace Albion.Network.Example
{
    public class TESTEvent : BaseEvent
    {
        public TESTEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Console.WriteLine(parameters);
        }
    }
}
