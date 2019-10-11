// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CalculateFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.FactoryPattern
{
    class CalculateFactory
    {
        /// <summary>
        /// Gets the calculation.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;
            if(type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
                return obj;
        }
    }
}
