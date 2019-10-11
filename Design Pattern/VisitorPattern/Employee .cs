// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Employee.cs" company="Bridgelabz">
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
    ///  The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(IVisitor visitor);
    }
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    /// <seealso cref="Design_Pattern.VisitorPattern.Element" />
    class Employee : Element
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }

        public Employee(string name, double income, int vacation)
        {
            Name = name;
            Income = income;
            VacationDays = vacation;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
