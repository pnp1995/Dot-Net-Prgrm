// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Windchillh.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BasicProgram.functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class WindChill
    {
        public void Wind()
        {

            double t = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(Console.ReadLine());
            if (t > 50 && v > 120 && v < 3)
            {
                Console.WriteLine("windchill is in  range:");
            }
            else
            {
                double w = 35.74 + (0.6215 * t) + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                Console.WriteLine("windchill:" + w);
            }
        }
    }
}
