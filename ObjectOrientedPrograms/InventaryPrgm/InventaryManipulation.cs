using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryManipulation
    {
        public static void ChangeName(string inventaryTypes, string itemName)
        {
            string newName;
            InventaryTypes inventaryTypes1 = InventaryFactory.ReadJsonFile();
            while (true)
            {
                Console.WriteLine("\nEnter the new name for" + inventaryTypes);
                newName = Console.ReadLine();
                if(InventaryUtility.ContainsCharacter(newName))
                {
                    Console.WriteLine("No Character allowed");
                    continue;
                }
                if(InventaryUtility.ConatainsDigit(newName))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }
                if(InventaryUtility.CheckString(newName))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }
                break;
            }
            if(inventaryTypes.Equals("RICE"))
            {
                List<RiceModel> riceList = inventaryTypes1.RiceList;
                foreach(RiceModel rice in riceList)
                {
                   if(rice.Name.Equals(itemName))
                   {
                        rice.Name = newName;
                        break;
                   }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if(inventaryTypes.Equals("PULSES"))
            {
                List<PulsesModel> pulseList = inventaryTypes1.PulseList;
                foreach (PulsesModel pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Name = newName;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if (inventaryTypes.Equals("WHEAT"))
            {
                List<WheatModel> wheatList = inventaryTypes1.WheatList;
                foreach (WheatModel pulse in wheatList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Name = newName;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
        }
        public static void ChangeWeight(string inventaryTypes, string itemName)
        {
            double newWeight;
            InventaryTypes inventaryTypes1 = InventaryFactory.ReadJsonFile();
            while (true)
            {
                Console.WriteLine("Enter the weight");
               string stringWeight = Console.ReadLine();
                try
                {
                    newWeight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input for weight");
                    continue;
                }
            }
            if(inventaryTypes.Equals("RICE"))
            {
                List<RiceModel> riceList = inventaryTypes1.RiceList;
                foreach (RiceModel rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.Weight = newWeight;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if (inventaryTypes.Equals("PULSES"))
            {
                List<PulsesModel> pulseList = inventaryTypes1.PulseList;
                foreach (PulsesModel pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Weight = newWeight;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if (inventaryTypes.Equals("WHEAT"))
            {
                List<WheatModel> wheatList = inventaryTypes1.WheatList;
                foreach (WheatModel pulse in wheatList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Weight = newWeight;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
        }
        public static void ChangePrice(string inventaryTypes, string itemName)
        {
            double newPrice;
            InventaryTypes inventaryTypes1 = InventaryFactory.ReadJsonFile();
            while (true)
            {
                Console.WriteLine("Enter price per kg");
                string stringPrice = Console.ReadLine();
                try
                {
                    newPrice = Convert.ToDouble(stringPrice);
                    break;
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input for orice oer kg");
                    continue;
                }
            }
            if (inventaryTypes.Equals("RICE"))
            {
                List<RiceModel> riceList = inventaryTypes1.RiceList;
                foreach (RiceModel rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.Priceperkg = newPrice;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if (inventaryTypes.Equals("PULSES"))
            {
                List<PulsesModel> pulseList = inventaryTypes1.PulseList;
                foreach (PulsesModel pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Priceperkg = newPrice;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
            if (inventaryTypes.Equals("WHEAT"))
            {
                List<WheatModel> wheatList = inventaryTypes1.WheatList;
                foreach (WheatModel pulse in wheatList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Priceperkg = newPrice;
                        break;
                    }
                }
                InventaryFactory.WriteToFile(inventaryTypes1);
                Console.WriteLine("updated Successfullyt");
            }
        }
    }
}
