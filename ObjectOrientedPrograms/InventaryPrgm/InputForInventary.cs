using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InputForInventary
    {
        public static void TakeInputForCreatingObject(string inventaryTypes)
        {
            string name = null;
            double weight = 0;
            double priceperkg = 0;
            while (true)
            {
                Console.WriteLine("Enter the name for" + inventaryTypes);
                name = Console.ReadLine();
                if (InventaryUtility.ConatainsDigit(name))
                {
                    continue;
                }
                if (InventaryUtility.ConatainsDigit(name))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }
                if (InventaryUtility.CheckString(name))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter the weight");
                string stringweight = Console.ReadLine();
                try
                {
                    weight = Convert.ToDouble(stringweight);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input for weight");
                    continue;
                }
            }
            if (inventaryTypes.Equals("Rice"))
            {
                WheatModel.CreateWheatObject(name, weight, priceperkg);
            }
            if (inventaryTypes.Equals("Pulse"))
            {
                RiceModel.CreateRiceObject(name, weight, priceperkg);
            }
            if (inventaryTypes.Equals("Wheat"))
            {
                PulsesModel.CreatePulsesObject(name, weight, priceperkg);
            }
        }
        public static void TakeInputForRemovingObject(string inventaryTypes)
        {
            while (true)
            {
                Console.WriteLine("Enter the item name you ewant to removed");
                string itemName = Console.ReadLine();
                if (!Regex.IsMatch(itemName, "^[a-zA-Z+$"))
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                if (inventaryTypes.Equals("Rice"))
                {
                    RiceModel.RemoveRiceObject(itemName);
                }
                if (inventaryTypes.Equals("Pulse"))
                {
                    WheatModel.RemoveWheatObject(itemName);
                }
                if (inventaryTypes.Equals("Wheat"))
                {
                    PulsesModel.RemovePulseObject(itemName);
                }
                break;
            }
        }
    }
}
