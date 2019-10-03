// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Inventaray Mangement program  .cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryMenu
    {
        public static void InventaryMenuList(string inventaryTypes)
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("What you want to perform");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.To view the existing inventary for " + inventaryTypes + " inventary");
                    Console.WriteLine("2.To remove an " + inventaryTypes + " item");
                    Console.WriteLine("3.TO Add " + inventaryTypes + " item");
                    Console.WriteLine("4.To Editing Existing " + inventaryTypes + " inventary");
                    Console.WriteLine("5.Back ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter your choice ");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            InventaryManager.InventaryList(inventaryTypes);
                            break;
                        case 2:
                            InputForInventary.TakeInputForCreatingObject(inventaryTypes);
                            break;
                        case 3:
                            InputForInventary.TakeInputForRemovingObject(inventaryTypes);
                            break;
                        case 4:
                            InventaryManipulationView.InventaryMainupulationView(inventaryTypes);
                            break;
                        case 5:
                            return;
                    }
                    Console.WriteLine("Do you want to Continue the press y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

