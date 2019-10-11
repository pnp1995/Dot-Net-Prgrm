// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Manager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.PrototypeDesign
{
    public  class Manager : IEmployee
    {
        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }
        public string CompanyName { get; set; }
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int StreetNumber { get; set; }
        public int ZipNumber { get; set; }
        public string State { get; set; }
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", CompanyName, EmployeeName, EmployeeId, Salary, Address, StreetNumber, State,ZipNumber);
        }
    }
}
