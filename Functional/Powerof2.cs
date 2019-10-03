// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Powerof2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram.functional
{
    /// <summary>
    /// powerof2 is classname
    /// </summary>
    class Powerof2
    {
        /// <summary>
        /// Powers this instance.
        /// </summary>
        public void power()
        {
            ////  Initialize the variable.
            int n = 31;
            int i = 0;
            int power = 1;
            Console.WriteLine("Power of 2 that are less than 2^" + 31);
            while (i <= n)
            {
                Console.WriteLine("2^" + i + "=" + power);
                power = power * 2;
                i++;
            }
        }
    }
}

