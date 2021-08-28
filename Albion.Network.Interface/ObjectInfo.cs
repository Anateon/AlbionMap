using System;

namespace Albion.Network.Interface
{
    public enum HarvestableTypeResource
    {
        WOOD, //дерево
        ROCK, //камень
        FIBER,//ткань
        HIDE, //шкура
        ORE   //руда
    }

    public class ObjectInfo
    {
        //public bool isMob { get; set; }
        //public bool isResurse { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public DateTime Time { get; set; }
        public bool Leave { get; set; }
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
        public bool PvpMode { get; set; }
    }

    public class MobInfo : LifeObject
    {
        public int Tier { get; set; }
    }

    public class ResurseInfo : ObjectInfo
    {
        public int Id { get; set; }
        public int Tier { get; set; }
        public int Lvl { get; set; }
        public HarvestableTypeResource Type { get; set; }
        public int Nuber { get; set; }
        public byte RowType { get; set; }
    }
}