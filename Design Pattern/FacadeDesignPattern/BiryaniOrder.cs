// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BiryaniOrder.cs" company="Bridgelabz">
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
    /// BIryaniorder is class
    /// </summary>
    /// <seealso cref="Design_Pattern.FacadeDesignPattern.IBiryani" />
    class BiryaniOrder : IBiryani
    {
        /// <summary>
        /// Gets the non veg biryani.
        /// </summary>
        public void GetNonVegBiryani()
        {
          try
            {
                Console.WriteLine("order veg Biryani.");
                Console.WriteLine("Your order successfully placed.");
                Console.WriteLine(" ");
                Console.WriteLine("Thank you");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Gets the veg biryani.
        /// </summary>
/        public void GetVegBiryani()
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
