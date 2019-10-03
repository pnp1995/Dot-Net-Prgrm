using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    public class RiceModel
    {
        private static IEnumerable<RiceModel> RiceList;
        private string name;
        private double weight;
        private double priceperkg;
        

        public RiceModel(string name, double weight, double priceperkg)
        {
            this.name = name;
            this.weight = weight;
            this.priceperkg = priceperkg;
        }

      
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Priceperkg { get; set; }
        public static void CreateRiceObject(string name,double weight, double Priceperkg)
        {
          RiceModel rice = new RiceModel(name, weight, Priceperkg);
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
            inventaryTypes.RiceList.Add(rice);
            InventaryUtility.pathData();
            Console.WriteLine("Added to Invantory successfully");
        }
        public static void RemoveRiceObject(string itemName)
        {
            InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
            foreach(RiceModel rice in RiceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    inventaryTypes.RiceList.Remove(rice);
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
            foreach (RiceModel rice in RiceList)
            {
                if (rice.Name.Equals(itemName))
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
