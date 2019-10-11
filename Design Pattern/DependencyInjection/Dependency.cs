// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Dependency.cs" company="Bridgelabz">
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
    /// Dependency is class.
    /// </summary>
    class Dependency
    {
        /// <summary>
        /// Dependencyinjections this instance.
        /// </summary>
        public void Dependencyinjection()
        {
            SBI sbi = new SBI();
            PNB pnb = new PNB();
            Customer customer1 = new Customer(sbi);
            Customer customer2 = new Customer(pnb);
            customer1.Interest();
            customer2.Interest();
        }
    }
}
