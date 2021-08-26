using System;
using System.Collections.Generic;

namespace Albion.Network.Interface
{
    public class NewResurseEvent : BaseEvent
    {
        public NewResurseEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            // 7 - Уровень; 11=тир; 10=кол-во предмета;   5=тип (8-камни 23-животные 4-деревьят 0-тоже деревья) t
            Id = int.Parse(parameters[0].ToString());
            Position = (float[])parameters[8];
            type = int.Parse(parameters[5].ToString());
            kolvo = parameters.TryGetValue(10, out object pvp) ? Int32.Parse(pvp.ToString()) : 0;
            lvl = int.Parse(parameters[7].ToString());
            tier = int.Parse(parameters[11].ToString());
        }

        public int Id { get; }
        public float[] Position { get; }
        public int lvl { get; }
        public int kolvo { get; }
        public int type { get; }
        public int tier { get; }
    }
}
