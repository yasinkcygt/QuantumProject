using System;

namespace NDP_Odev4
{
    internal class AntiMatter : QuantumObject, ICritical
    {
        public AntiMatter(string id, int stability, int dangerLevel) 
            : base(id, stability, dangerLevel) { }

        public override void Analyze()
        {
            int newValue = Stability - 25;
            if (newValue <= 0) throw new QuantumCollapseException(ObjectID);

            Stability = newValue;
            Console.WriteLine("The fabric of the universe trembles during analysis...");
        }

        public void EmergencyCooling()
        {
            int newValue = Stability + 50;
            // Safety Check: Prevent cooling if it results in an overflow beyond limits
            if (newValue >= 100)
            {
                Console.WriteLine("Warning: Cooling limit reached. Further cooling impossible.");
                return;
            }
            Stability = newValue;
            Console.WriteLine($"Thermal extraction complete. Stability: {Stability}%");
        }
    }
}