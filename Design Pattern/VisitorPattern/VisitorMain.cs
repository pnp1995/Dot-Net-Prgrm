// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VisitorMain.cs" company="Bridgelabz">
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
    /// VisitorMain is class
    /// </summary>
    class VisitorMain
    {
        public static void Pattern()
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
        }
    }
}

