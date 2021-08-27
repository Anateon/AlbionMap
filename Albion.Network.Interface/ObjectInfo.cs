using System;

namespace Albion.Network.Interface
{
    public class ObjectInfo
    {
        //public bool isMob { get; set; }
        //public bool isResurse { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public DateTime time { get; set; }
        public bool leave { get; set; }
        public bool NeedUpdate { get; set; }
    }

    public class LifeObject : ObjectInfo
    {
        public int FullHP { get; set; }
        public int NowHP { get; set; }

    }
    public class PlayerInfo : LifeObject
    {
        public string Name { get; set; }
        public bool pvpMode { get; set; }
    }

    public class MobInfo : LifeObject
    {
        public int Tier { get; set; }
    }

    public class ResurseInfo : ObjectInfo
    {
        public int Id { get; set; }
        public int Lvl { get; set; }
        public int Tier { get; set; }
        public bool isAnimal { get; set; }
        public bool isTree { get; set; }
        public bool isStone { get; set; }
        public int nuber { get; set; }
        public byte resurseType { get; set; }
    }
}