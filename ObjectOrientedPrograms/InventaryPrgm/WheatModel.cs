using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
   public class WheatModel
   {
        private string name;
        private double weight;
        private double priceperkg;

        public WheatModel(string name, double weight, double priceperkg)
        {
            this.name = name;
            this.weight = weight;
            this.priceperkg = priceperkg;
        }

       public static IEnumerable<WheatModel> WheatList { get; private set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Priceperkg { get; set; }
        public static void CreateWheatObject(string name, double weight, double Priceperkg)
        {
            WheatModel wheat = new WheatModel(name, weight, Priceperkg);
            InventaryTypes invantoryTypes = InventaryFactory.ReadJsonFile();
            invantoryTypes.WheatList.Add(wheat);
            InventaryUtility.pathData();
            Console.WriteLine("Added to Invantory successfully");
        }
        public static void RemoveWheatObject(string itemName)
        {
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
            foreach (WheatModel wheat in WheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    inventaryTypes.WheatList.Remove(wheat);
                    InventaryFactory.WriteToFile(inventaryTypes);
                    Console.WriteLine("item" + itemName + "removed Successfully");
                    Console.WriteLine(".......");
                    return;
                }
            }
            Console.WriteLine("item" + itemName + "removed not found");
        }
        public static bool DoesObjectExist(string itemName)
        {
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
            //List<RiceModel> riceList = inventaryTypes.RiceList;
            foreach (WheatModel wheat in WheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return "Name:" + this.Name + "\nWeight:" + this.weight + "\nPriceperkg" + this.priceperkg.ToString();
        }
    }
}
