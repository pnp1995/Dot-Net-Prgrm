// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IncomeVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.VisitorPattern
{
    /// <summary>
    ///  A 'ConcreteVisitor' class.
    /// </summary>
    /// <seealso cref="Design_Pattern.VisitorPattern.IVisitor" />
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.Income);
        }
    }
}
