// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class SquareRoot
    {
        /// <summary>
        /// SQRTs this instance.
        /// </summary>
        public static void Sqrt()
        {
            //// read in the command line argument
            Console.WriteLine("enter the value");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            //// repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;

                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
    }
}
