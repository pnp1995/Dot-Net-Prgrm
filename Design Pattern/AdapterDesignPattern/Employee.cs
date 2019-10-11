// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.AdapterDesignPattern
{
    public class Employee
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        public string[][] GetEmployees()
        {
            Console.WriteLine("Enter how many employee detail you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            string[][] employee = new string[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter " + ++i + " employee name");
                string name = Console.ReadLine();
                --i;
                Console.WriteLine("enter " + name + " employee Id");
                string id = Console.ReadLine();
                Console.WriteLine("enter " + name + " Designation");
                string Designation = Console.ReadLine();
                employee[i] = new string[] { id, name, Designation };
            }
            return employee;
        }
    }
 }

