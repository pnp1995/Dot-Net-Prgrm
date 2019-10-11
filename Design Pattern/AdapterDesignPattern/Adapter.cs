// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Adapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.AdapterDesignPattern
{
    /// <summary>
    /// Adapter is class
    /// </summary>
    public class Adapter
    {
        /// <summary>
        /// Adapters this instance.
        /// </summary>
        public void adapter()
        {
            IEmployee employee = new EmployeeAdapter();
            HrRequest hr = new HrRequest(employee);
            hr.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
