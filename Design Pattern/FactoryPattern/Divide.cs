// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Divide.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.FactoryPattern
{
   public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a / b is {0} ", a / b);

        }
    }
}
