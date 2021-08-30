﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Albion.Network
{
    public abstract class EventPacketHandler<TEvent> : PacketHandler<EventPacket> where TEvent : BaseEvent
    {
        private readonly int eventCode;

        public EventPacketHandler(int eventCode)
        {
            this.eventCode = eventCode;
        }

        protected abstract Task OnActionAsync(TEvent value);

        protected internal override Task OnHandleAsync(EventPacket packet)
        {

#if DEBUG
            if (eventCode == -666)
            {
                if (/*packet.EventCode == 331 || packet.EventCode == 332*/ /*packet.EventCode == 115*/ packet.EventCode == 36)
                {
                    string writePath = @"C:\logIvents.txt";

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(packet.EventCode);
                    }

                    Console.WriteLine($"{packet.EventCode}\t{(EnumEvents) packet.EventCode}");
                    string json = JsonConvert.SerializeObject(packet.Parameters);

                    Console.WriteLine(json);

                    return NextAsync(packet);

                }
                //Console.WriteLine($"{packet.EventCode}\t{(EnumEvents) packet.EventCode}");
            }
#endif

            if (eventCode != packet.EventCode)
            {
                return NextAsync(packet);
            }
            else
            {
                TEvent instance = (TEvent)Activator.CreateInstance(typeof(TEvent), packet.Parameters);

                return OnActionAsync(instance);
            }
        }
    }
}