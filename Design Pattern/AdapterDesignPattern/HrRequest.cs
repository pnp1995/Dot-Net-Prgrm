// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HrRequest.cs" company="Bridgelabz">
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
    /// HrRequest is class
    /// </summary>
    public class HrRequest
    {
        private IEmployee employeeDetails;
        /// <summary>
        /// Initializes a new instance of the <see cref="HrRequest"/> class.
        /// </summary>
        /// <param name="employeeDetails">The employee details.</param>
        /// //// using the constructor, if they both have the same name. 
        public HrRequest(IEmployee employeeDetails)
        {
            this.employeeDetails = employeeDetails;
        }   
        public void ShowEmployeeList()
        {
            List<string> employee = employeeDetails.GetEmployeeList();
            Console.WriteLine("**Employee List**");
            Console.WriteLine("Employee Id\tEmployee Name\tEmployee Designation");
            Console.WriteLine(" ");
            foreach(var item in employee)
            {
                Console.Write(item);

            }
        }
    }
}
