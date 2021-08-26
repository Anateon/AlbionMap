using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Albion.Network.Interface
{
    public class NewCharacterEvent : BaseEvent
    {
        public NewCharacterEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = int.Parse(parameters[0].ToString());
            Name = parameters[1].ToString();
            //GuildName = parameters.TryGetValue(8, out object guildName) ? guildName.ToString() : null;
            Position = (float[])parameters[12];

            NowHP = (int)(parameters.TryGetValue(18, out object hp1) ? double.Parse(hp1.ToString()) : 0);
            FullHP = (int)(parameters.TryGetValue(19, out object hp2) ? double.Parse(hp2.ToString()) : 0);
            int pvpTmp = parameters.TryGetValue(45, out object pvp) ? Int32.Parse(pvp.ToString()) : 0;
            if (pvpTmp == 0 || pvpTmp == 2 || pvpTmp == 4 || pvpTmp == 6) 
            {
                PVPmode = false;
            }
            else
            {
                Console.WriteLine(pvpTmp);
                PVPmode = true;
            }
        }

        public int Id { get; }
        public string Name { get; }
        //public string GuildName { get; }
        public float[] Position { get; }
        public int NowHP { get; }
        public int FullHP { get; }
        public bool PVPmode { get; }

    }
}
