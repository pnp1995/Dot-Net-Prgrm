// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SBI.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.DependencyInjection
{
    class SBI : IRBI
    {
        /// <summary>
        /// Gets the rate of interest.
        /// </summary>
        public void GetRateOfInterest()
        {
            Console.WriteLine("Rate of Interest in SBI Bank is: 7.5%");
        }
    }
}
