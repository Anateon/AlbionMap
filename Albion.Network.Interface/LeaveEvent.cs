using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Albion.Network.Interface
{
    public class LeaveEvent : BaseEvent
    {
        public LeaveEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
        }
        public int Id { get; }

    }
}
