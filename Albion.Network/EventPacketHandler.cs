using System;
using System.IO;
using System.Threading.Tasks;

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
                    if (packet.EventCode == 2)
                    {
                        string writePath = @"C:\logIvents.txt";

                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(packet.EventCode);
                        }

                        TEvent instance = (TEvent)Activator.CreateInstance(typeof(TEvent), packet.Parameters);
                        Console.WriteLine(packet.EventCode + "\t" + Enum.GetName(typeof(EnumEvents), (int)packet.EventCode));
                        return OnActionAsync(instance);
                    }
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