// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.AdapterDesignPattern
{
   public class EmployeeAdapter : Employee, IEmployee
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns></returns>
        public List<string>GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach(string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add("\t");
                employeeList.Add(employee[1]);
                employeeList.Add("\t");
                employeeList.Add(employee[2]);
                employeeList.Add("\t");

            }
            return employeeList; 
        }
    }
  
}
