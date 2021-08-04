using System;
using System.Collections.Generic;

namespace Albion.Network.Example
{
    public class NewMobEvent : BaseEvent
    {
        public NewMobEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = $"1) {(parameters.TryGetValue(0, out object q) ? q.ToString() : null)}";
                 //$"\n2) {(parameters.TryGetValue(2, out object w) ? w.ToString() : null)}" +
                 //$"\n3) {(parameters.TryGetValue(3, out object e) ? e.ToString() : null)}" +
                 //$"\n4) {(parameters.TryGetValue(4, out object r) ? r.ToString() : null)}" +
                 //$"\n5) {(parameters.TryGetValue(5, out object t) ? t.ToString() : null)}" +
                 //$"\n6) {(parameters.TryGetValue(6, out object y) ? y.ToString() : null)}" +
                 //$"\n7) {(parameters.TryGetValue(7, out object z) ? z.ToString() : null)}" +
                 //$"\n8) {(parameters.TryGetValue(8, out object x) ? x.ToString() : null)}" +
                 //$"\n9) {(parameters.TryGetValue(9, out object c) ? c.ToString() : null)}" +
                 //$"\n10) {(parameters.TryGetValue(10, out object v) ? v.ToString() : null)}";
            Position = (float[])parameters[7];
        }

        public string Id { get; }
        public float[] Position { get; }
    }
}
