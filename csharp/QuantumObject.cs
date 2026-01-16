using System;

namespace NDP_Odev4
{
    public abstract class QuantumObject
    {
        public string ObjectID { get; set; }
        private int stability;
        private int dangerLevel;

        public int Stability
        {
            get => stability;
            set
            {
                // Encapsulation: Ensure stability stays within valid range
                if (value >= 0 && value <= 100)
                    stability = value;
                else
                    Console.WriteLine("System Alert: Stability must be between 0 and 100.");
            }
        }

        public int DangerLevel
        {
            get => dangerLevel;
            set
            {
                // Encapsulation: Ensure danger level stays within valid range
                if (value >= 1 && value <= 10)
                    dangerLevel = value;
                else
                    Console.WriteLine("System Alert: Danger level must be between 1 and 10.");
            }
        }

        public QuantumObject(string id, int stability, int dangerLevel)
        {
            ObjectID = id;
            Stability = stability;
            DangerLevel = dangerLevel;
        }

        public abstract void Analyze();

        public string GetStatusInfo()
        {
            return $"[ID: {ObjectID}] | Stability: {Stability}% | Danger Level: {DangerLevel}/10";
        }
    }
}