// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Add.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.FactoryPattern
{
    /// <summary>
    /// Add is a class.
    /// </summary>
    /// <seealso cref="Design_Pattern.FactoryPattern.ICalculate" />
    public class Add : ICalculate
   {
        /// <summary>
        /// Calculates the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public void Calculate(double a , double b)
        {
            Console.WriteLine("a + b is {0}", a + b);

        }
   }
}
