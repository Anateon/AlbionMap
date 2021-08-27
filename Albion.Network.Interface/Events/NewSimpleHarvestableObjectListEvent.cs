using System;
using System.Collections.Generic;
using System.Linq;

namespace Albion.Network.Interface
{
    public class NewSimpleHarvestableObjectListEvent : BaseEvent
    {
        public NewSimpleHarvestableObjectListEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            List<int> a0 = new List<int>();
            if (parameters[0].GetType() == typeof(Byte[]))
            {
                Byte[] typeListByte = (Byte[])parameters[0]; //list of types
                foreach (Byte b in typeListByte)
                    a0.Add(b);
            }
            else if (parameters[0].GetType() == typeof(Int16[]))
            {
                Int16[] typeListByte = (Int16[])parameters[0]; //list of types
                foreach (Int16 b in typeListByte)
                    a0.Add(b);
            }
            else
            {
                Console.WriteLine("onNewSimpleHarvestableObjectList type error: " + parameters[0].GetType());
                return;
            }
            try
            {
                /*
                Key = 0, Value = System.Int16[] //id
                Key = 1, Value = System.Byte[] // type WOOD etc
                Key = 2, Value = System.Byte[] // tier
                Key = 3, Value = System.Single[] //location
                Key = 4, Value = System.Byte[] // size
                Key = 252, Value = 29
                 */
                Byte[] a1 = (Byte[])parameters[1]; //list of types
                Byte[] a2 = (Byte[])parameters[2]; //list of tiers
                Single[] a3 = (Single[])parameters[3]; //list of positions X1, Y1, X2, Y2 ...
                Byte[] a4 = (Byte[])parameters[4]; //size

                for (int i = 0; i < a0.Count; i++)
                {
                    MobsList.Add(new ResurseInfo()
                    {  
                        Id = (int)a0.ElementAt(i),
                        Tier = 0,
                        X = (Single)a3[i * 2],
                        Y = (Single)a3[i * 2 + 1],
                        nuber = (byte)a4[i],
                        Lvl = (byte)a2[i],
                        NeedUpdate = true,
                        leave = false,
                        time = DateTime.Now,
                        resurseType = (byte)a1[i]
                    });
                    //
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("eL: " + e.ToString());
            }
        }

        public List<ResurseInfo> MobsList = new List<ResurseInfo>();

    }
}
