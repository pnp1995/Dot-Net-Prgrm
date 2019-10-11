// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PNB.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.DependencyInjection
{
    /// <summary>
    /// PNB is class
    /// </summary>
    /// <seealso cref="Design_Pattern.DependencyInjection.IRBI" />
    class PNB : IRBI
    {
        /// <summary>
        /// Gets the rate of interest.
        /// </summary>
        public void GetRateOfInterest()
        {
            Console.WriteLine("Rate of Interest in PNB Bank is: 8.5%");
        }
    }
}
