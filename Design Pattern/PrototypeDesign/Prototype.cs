// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Prototype.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.PrototypeDesign
{
    class Prototype
    {
        /// <summary>
        /// Prototypes the pattern.
        /// </summary>
        public void PrototypePattern()
        {
            try
            {
                char choice;
                int choose;
                do
                {
                    Console.WriteLine("**Account Details**");
                    Console.WriteLine("");
                    Console.WriteLine("Managers");
                    Console.WriteLine("Operator Employee");
                    Console.WriteLine("Which account you want to view");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine("");
                    choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Details details = new Details();
                            details.ManagerDetails();
                            break;
                        case 2:
                            Details details2 = new Details();
                            details2.OperatorEmployee();
                            break;
                    }
                    Console.WriteLine("Do you want to continue press y");
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
