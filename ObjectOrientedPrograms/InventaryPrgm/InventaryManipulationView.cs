using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryManipulationView
    {
        public static void InventaryMainupulationView(string inventaryTypes)
        {
            Console.WriteLine("Enter the item name you want to edit");
            string itemName = Console.ReadLine();
            if(inventaryTypes.Equals("Rice"))
            {
                if(RiceModel.DoesObjectExist(itemName)== false)
                {
                    Console.WriteLine("item" + itemName + "does not exist");
                    return;
                }
            }
            if (inventaryTypes.Equals("Pulse"))
            {
                if (PulsesModel.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item" + itemName + "does not exist");
                    return;
                }
            }
            if (inventaryTypes.Equals("Wheat"))
            {
                if (WheatModel.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item" + itemName + "does not exist");
                    return;
                }
            }
            EditMenu(inventaryTypes, itemName);

        }
        public static void EditMenu(string inventaryTypes,string itemName)
        {
            while(true)
            {
                Console.WriteLine("Choose what do you want to edit");
                Console.WriteLine("0) To go to back");
                Console.WriteLine("1) Name");
                Console.WriteLine("2) Weight");
                Console.WriteLine("3) priceperkg");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "0":
                        {
                            return;
                        }
                    case "1":
                        {
                            InventaryManipulation.ChangeName(inventaryTypes, itemName);
                            break;
                        }
                    case "2":
                        {
                            InventaryManipulation.ChangeWeight(inventaryTypes, itemName);
                            break;
                        }
                    case "3":
                        {
                            InventaryManipulation.ChangePrice(inventaryTypes, itemName);
                            break;
                        }
                }
            }
        }
    }
}
