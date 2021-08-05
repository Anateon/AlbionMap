using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Albion.Network.Interface
{
    public class NewCharacterEvent : BaseEvent
    {
        public NewCharacterEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = parameters[0].ToString();
            Name = parameters[1].ToString();
            //GuildName = parameters.TryGetValue(8, out object guildName) ? guildName.ToString() : null;
            Position = (float[])parameters[12];

            NowHP = parameters.TryGetValue(18, out object hp1) ? Int32.Parse(hp1.ToString()) : 0;
            FullHP = parameters.TryGetValue(19, out object hp2) ? Int32.Parse(hp2.ToString()) : 0;
        }

        public string Id { get; }
        public string Name { get; }
        //public string GuildName { get; }
        public float[] Position { get; }
        public int NowHP { get; }
        public int FullHP { get; }

    }
}
