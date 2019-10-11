// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VacationVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.VisitorPattern
{
    /// <summary>
    /// / A 'ConcreteVisitor' class
    /// </summary>
    /// <seealso cref="Design_Pattern.VisitorPattern.IVisitor" />
    class VacationVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // And because you all helped have such a great year, all my employees get three extra paid time off days each!
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.VacationDays);
        }

    }
}
