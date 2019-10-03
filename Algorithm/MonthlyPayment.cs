// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MonthlyPayment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// MonthlyPayment  is a class where i created the payment method to find the rate of intrest
    /// </summary>
    class MonthlyPayment
    {
        /// <summary>
        /// Payments this instance.
        /// </summary>
        public static void Payment()
        {
           Console.WriteLine("Enter the loan amount");
           double principal = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("enter the year");
           double year = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the rate of intrest");
           double rate = Convert.ToDouble(Console.ReadLine());
           double n = 12 * year;
           double r = rate / (12 * 100);

            //// using the formula by using requird function. 
            double payment = (principal*r)/(1-Math.Pow((1+r),-n));
            Console.WriteLine(Math.Round(payment));
        }

    }
}
