// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HarmonicNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram.functional
{/// <summary>
/// harmonicnumber is class name
/// </summary>
    class HarmonicNumber
    {
        /// <summary>
        /// Harmonic is method name
        /// </summary>
        public void Harmonic()
        {
            ////ask fpor input of harmonic value
            double N;
            Console.WriteLine("enter harmonic value:");
            N = int.Parse(Console.ReadLine());
           //// Take the loop and check the condition for nth harmonic value
            if (N != 0) 
            {
                double r = 0.0;
                for (double i = 1; i <= N; i++)
                {
                    r = r + (1 / i);
                }

                Console.WriteLine("the Nth Harmonic number will be:" + r);

            }
        }
    }
}
