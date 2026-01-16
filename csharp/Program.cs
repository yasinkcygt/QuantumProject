using System;
using System.Collections.Generic;
using System.Linq;

namespace NDP_Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuantumObject> storageList = new List<QuantumObject>();

            while (true)
            {
                Console.WriteLine("\n============================================");
                Console.WriteLine("      QUANTUM STORAGE CONTROL PANEL");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Add New Object (Random Generation)");
                Console.WriteLine("2. List Inventory (Status Report)");
                Console.WriteLine("3. Analyze Object (Decreases Stability)");
                Console.WriteLine("4. Emergency Cooling (Critical Objects Only)");
                Console.WriteLine("5. Shutdown System");
                Console.Write("\nOperation Selection: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Error: Please enter a valid numeric command.");
                    continue;
                }

                if (choice == 5) break;

                switch (choice)
                {
                    case 1:
                        AddNewObject(storageList);
                        break;
                    case 2:
                        ShowInventory(storageList);
                        break;
                    case 3:
                        AnalyzeObject(storageList);
                        break;
                    case 4:
                        PerformCooling(storageList);
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        static void AddNewObject(List<QuantumObject> list)
        {
            Random rn = new Random();
            int typeIndex = rn.Next(0, 3);

            Console.Write("Enter Object ID: ");
            string id = Console.ReadLine() ?? "Unknown";
            if (string.IsNullOrWhiteSpace(id)) { Console.WriteLine("ID cannot be empty."); return; }

            Console.Write("Enter Initial Stability (1-99): ");
            if (!int.TryParse(Console.ReadLine(), out int stability)) stability = 0;

            Console.Write("Enter Danger Level (1-10): ");
            if (!int.TryParse(Console.ReadLine(), out int danger)) danger = 0;

            QuantumObject? newObj = typeIndex switch
            {
                0 => new DataPacket(id, stability, danger),
                1 => new DarkMatter(id, stability, danger),
                2 => new AntiMatter(id, stability, danger),
                _ => null
            };

            // Double-check encapsulation constraints before adding to list
            if (newObj != null && newObj.Stability > 0 && newObj.DangerLevel >= 1)
            {
                list.Add(newObj);
                Console.WriteLine($"Success: {newObj.GetType().Name} added to storage.");
            }
            else
            {
                Console.WriteLine("Failure: Invalid parameters detected. Object rejected.");
            }
        }

        static void ShowInventory(List<QuantumObject> list)
        {
            if (list.Count == 0) Console.WriteLine("\nStorage empty.");
            else list.ForEach(o => Console.WriteLine(o.GetStatusInfo()));
        }

        static void AnalyzeObject(List<QuantumObject> list)
        {
            Console.Write("Enter ID to Analyze: ");
            string searchID = Console.ReadLine() ?? "";
            var obj = list.FirstOrDefault(o => o.ObjectID == searchID);

            if (obj != null)
            {
                try
                {
                    Console.WriteLine($"Pre-Analysis Stability: {obj.Stability}%");
                    obj.Analyze();
                    Console.WriteLine($"Post-Analysis Stability: {obj.Stability}%");
                }
                catch (QuantumCollapseException ex)
                {
                    Console.WriteLine("\n!!! CRITICAL SYSTEM COLLAPSE !!!");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0); // Terminal failure
                }
            }
            else Console.WriteLine("Object ID not found.");
        }

        static void PerformCooling(List<QuantumObject> list)
        {
            Console.Write("Enter ID for Cooling: ");
            string searchID = Console.ReadLine() ?? "";
            var obj = list.FirstOrDefault(o => o.ObjectID == searchID);

            if (obj == null) Console.WriteLine("Object ID not found.");
            else if (obj is ICritical criticalObj) criticalObj.EmergencyCooling();
            else Console.WriteLine("Denied: This object type is thermally stable and cannot be cooled.");
        }
    }
}