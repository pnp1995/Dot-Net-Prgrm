// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Inventary Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryOption
    {
        public  void InventaryManagementMethod()
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("******* WHAT YOU WANT ********");
                    Console.WriteLine("");
                    Console.WriteLine("1.Rice");
                    Console.WriteLine("2.Pulses");
                    Console.WriteLine("3.Wheat");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your choice");
                    Console.WriteLine("");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            InventaryMenu.InventaryMenuList("Rice");
                            break;
                        case 2:
                            InventaryMenu.InventaryMenuList("Pulse");
                            break;
                        case 3:
                            InventaryMenu.InventaryMenuList("Wheat");
                            break;
                        case 4:
                            return;
                    }
                    Console.WriteLine("Do you want to Continue the press  Y");
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
