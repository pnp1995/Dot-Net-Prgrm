// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Order.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.FacadeDesignPattern
{
    /// <summary>
    /// Order is a class
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets the order.
        /// </summary>
        public void GetOrder()
        {
            try
            {
                char condition;
                do
                {
                    int choice;
                    Console.WriteLine("1.BiryaniOrder.");
                    Console.WriteLine("2.MealOrder");
                    Console.WriteLine("");
                    Console.WriteLine("What do you want to order");
                    Console.WriteLine("");
                    choice = Convert.ToInt32(Console.ReadLine());
                    FacadeDesignPattern.FacadeResto FacadeforCustomer = new FacadeResto();
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("** Biryani **");
                                char condition1;
                                int choice1;
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("1.VegBiryani");
                                    Console.WriteLine("2.NonVegBiryani");
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want");
                                    choice1 = Convert.ToInt32(Console.ReadLine());
                                    switch (choice1)
                                    {
                                        case 1:
                                            Console.WriteLine("Customer order for VegBiryani");
                                            FacadeforCustomer.OrderVegBiryani();
                                            break;

                                        case 2:
                                            Console.WriteLine("Customer order NonVegBiryani");
                                            FacadeforCustomer.OrderNonVegBiryani();
                                            break;

                                    }
                                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue");
                                    condition1 = Convert.ToChar(Console.ReadLine());
                                }
                                while (condition1 == 'y' || condition1 == 'Y');
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("** Meals **");
                                char condition2;
                                int choice2;
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("1.VegMeals");
                                    Console.WriteLine("2.NonVegMeals");
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want");
                                    choice2 = Convert.ToInt32(Console.ReadLine());
                                    switch (choice2)
                                    {
                                        case 1:
                                            Console.WriteLine("Customer order for VegMeals");
                                            FacadeforCustomer.OrderVegMeals();
                                            break;
                                        case 2:
                                            Console.WriteLine("Customer order NonVegMeals");
                                            FacadeforCustomer.OrderNonVegMeals();
                                            break;
                                    }
                                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue");
                                    condition2 = Convert.ToChar(Console.ReadLine());
                                }
                                while (condition2 == 'y' || condition2 == 'Y');
                            }
                            break;
                    }
                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue");
                    condition = Convert.ToChar(Console.ReadLine());
                }
                while (condition == 'y' || condition == 'Y');
                Console.WriteLine("Thanku your order is placed");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 

    }
}
