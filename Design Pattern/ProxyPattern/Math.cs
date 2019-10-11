// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Math.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.ProxyPattern
{
    /// <summary>
    /// Math is class.
    /// </summary>
    /// <seealso cref="Design_Pattern.ProxyPattern.IMath" />
    class Math : IMath
    {
        /// <summary>
        /// Adds the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            return x + y;
        }
        /// <summary>
        /// Subs the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }
}
