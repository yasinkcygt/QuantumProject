using System;

namespace NDP_Odev4
{
    internal class DataPacket : QuantumObject
    {
        public DataPacket(string id, int stability, int dangerLevel) 
            : base(id, stability, dangerLevel) { }

        public override void Analyze()
        {
            int newValue = Stability - 5;
            if (newValue <= 0) throw new QuantumCollapseException(ObjectID);

            Stability = newValue;
            Console.WriteLine("Data decryption successful. Content read.");
        }
    }
}