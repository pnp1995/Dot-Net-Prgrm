// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Factor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BasicProgram.functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// factor is class name
    /// </summary>
    class Factor
    {
        /// <summary>
        /// Facts this instance.
        /// </summary>
        public void fact()
        {
            ////asks for input of number and pass the value
            Console.WriteLine("Enter Number(N)");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("prime factor of " + number + " is :");
            findPrimeFactor( number);
        }
        /// <summary>
        /// Finds the prime factor.
        /// </summary>
        /// <param name="number">The number.</param>
        public void findPrimeFactor(int number)
        {
            for (int i = 1; i * i <= number; i++)
                if (number % i == 0)
                    Console.WriteLine("" + i);

        }

    }

}

