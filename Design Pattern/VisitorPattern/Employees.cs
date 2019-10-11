// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employees.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.VisitorPattern
{
    class Employees
    {
        private List<Employee> employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

    // Three employee types


    class Clerk : Employee

    {
        // Constructor

        public Clerk()
          : base("Ram", 25000.0, 14)
        {
        }
    }

    class Director : Employee

    {
        // Constructor

        public Director()
          : base("Rohan", 35000.0, 16)
        {
        }
    }

    class President : Employee

    {
        // Constructor

        public President()
          : base("Pnp", 45000.0, 21)
        {
        }
    }
}
    

