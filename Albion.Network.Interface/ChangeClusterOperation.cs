using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class ChangeClusterOperation : BaseOperation
    {
        public ChangeClusterOperation(Dictionary<byte, object> parameters) : base(parameters)
        {
            Time = (long)parameters[0];
            Position = (float[])parameters[1];
            //Direction = (float)parameters[2];
            NewPosition = (float[])parameters[3];
            //Speed = (float)parameters[4];
        }

        public long Time { get; }
        public float[] Position { get; }
        //public float Direction { get; }
        public float[] NewPosition { get; }
        //public float Speed { get; }
    }
}
