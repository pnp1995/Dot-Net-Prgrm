// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Customer.cs" company="Bridgelabz">
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
    /// Customer is a class
    /// </summary>
    class Customer
    {
        /// <summary>
        /// The rbi
        /// </summary>
        private IRBI rbi;
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="rBI">The r bi.</param>
        public Customer(IRBI rBI)
        {
            rbi = rBI;
        }
        /// <summary>
        /// Interests this instance.
        /// </summary>
        public void Interest()
        {
            rbi.GetRateOfInterest();
        }
    }
}
