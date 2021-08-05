using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class MoveEvent : BaseEvent
    {
        public MoveEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            byte[] bytes = (byte[])parameters[1];

            Id = int.Parse(parameters[0].ToString());
            Position = new float[] { BitConverter.ToSingle(bytes, 9), BitConverter.ToSingle(bytes, 13) };

        }

        public int Id { get; }
        public float[] Position { get; }
    }
}
