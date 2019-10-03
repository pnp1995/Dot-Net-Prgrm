
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    public class PulsesModel
    {
        private static readonly IEnumerable<PulsesModel> PulseList;
        private string name;
        private double weight;
        private double priceperkg;

        public PulsesModel(string name, double weight, double priceperkg)
        {
            this.name = name;
            this.weight = weight;
            this.priceperkg = priceperkg;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Priceperkg { get; set; }
        public static void CreatePulsesObject(string name, double weight, double Priceperkg)
        {
            PulsesModel pulse = new PulsesModel(name, weight, Priceperkg);
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
            inventaryTypes.PulseList.Add(pulse);
            InventaryUtility.pathData();
            Console.WriteLine("Added to Invantory successfully");
        }

        internal static bool DoesObjectExist(string itemName)
        {
            throw new NotImplementedException();
        }

        public static void RemovePulseObject(string itemName)
        {
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
           // List<PulsesModel> pulseList = inventaryTypes.PulseList;
            foreach(PulsesModel pulses in PulseList)
            {
                if (pulses.Name.Equals(itemName))
                {
                    inventaryTypes.PulseList.Remove(pulses);
                    InventaryFactory.WriteToFile(inventaryTypes);
                    Console.WriteLine("item" + itemName + " removed Successfully");
                    Console.WriteLine(".......");
                    return;
                }
            }
            Console.WriteLine("item" + itemName + " removed not found");
        }
    }
}