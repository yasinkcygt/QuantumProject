using System;

namespace NDP_Odev4
{
    internal class DarkMatter : QuantumObject, ICritical
    {
        public DarkMatter(string id, int stability, int dangerLevel) 
            : base(id, stability, dangerLevel) { }

        public override void Analyze()
        {
            int newValue = Stability - 15;
            if (newValue <= 0) throw new QuantumCollapseException(ObjectID);

            Stability = newValue;
            Console.WriteLine("Dark matter composition analyzed.");
        }

        public void EmergencyCooling()
        {
            int newValue = Stability + 50;
            // Logic Safety: Ensure stability doesn't exceed 100%
            Stability = (newValue > 100) ? 99 : newValue;
            Console.WriteLine($"Cooling successful. Current Stability: {Stability}%");
        }
    }
}