// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Design_Pattern.Reflection
{
    /// <summary>
    /// Employee is a class.
    /// </summary>
    class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="employeeName">Name of the employee.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="salary">The salary.</param>
        public Employee(int employeeId, string employeeName, string designation, double salary)
        {
            this.EmployeeID = employeeId;
            this.EmployeeName = employeeName;
            this.Designation = designation;
            this.Salary = salary;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.EmployeeID = 0;
            this.EmployeeName = string.Empty;
            this.Designation = string.Empty;
            this.Salary = 0;
        }
        public void PrintId()
        {
            Console.WriteLine("Employee ID = {0}", this.EmployeeID);
        }
        public void PrintName()
        {
            Console.WriteLine("Employee Name = {0}", this.EmployeeName);
        }
        public void PrintDesignation()
        {
            Console.WriteLine("Employee Designation = {0}", this.Designation);
        }
        public void PrintSalary()
        {
            Console.WriteLine("Employee Salary = {0}", this.Salary);
        }
    }
}
