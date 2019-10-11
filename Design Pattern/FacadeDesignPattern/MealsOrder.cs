// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MealsOrder.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.FacadeDesignPattern
{
    class MealsOrder : IMeals
    {
        public void VegMeals()
        {
            try
            {
                Console.WriteLine("order veg Meals.");
                Console.WriteLine("Your order successfully placed.");
                Console.WriteLine(" ");
                Console.WriteLine("Thank you");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void NonVegMeals()
        {
            try
            {
                Console.WriteLine("order Nonveg Biryani.");
                Console.WriteLine("Your order successfully placed.");
                Console.WriteLine(" ");
                Console.WriteLine("Thank you");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
