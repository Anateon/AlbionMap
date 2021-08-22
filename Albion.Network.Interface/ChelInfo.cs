using System;

namespace Albion.Network.Interface
{
    public class ChelInfo
    {
        public bool isMob { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public string name { get; set; }
        public DateTime time { get; set; }
        public bool leave { get; set; }
        public int FullHP { get; set; }
        public int NowHP { get; set; }
        public bool NeedUpdate { get; set; }
    }
}