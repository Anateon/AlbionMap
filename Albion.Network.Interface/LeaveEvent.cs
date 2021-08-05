using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Albion.Network.Interface
{
    public class LeaveEvent : BaseEvent
    {
        public LeaveEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = parameters[0].ToString();
        }
        public string Id { get; }

    }
}
