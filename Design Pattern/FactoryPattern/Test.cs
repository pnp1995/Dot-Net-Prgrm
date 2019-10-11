// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Test.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.FactoryPattern
{
   public class Test
    {
       public void main ()  
        {
            Console.WriteLine("Enter the first number");
            string  input1= Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input1, out num1);
            if(!result)
            {
                Console.WriteLine("please enter the again");
                return;
            }
            Console.WriteLine("Enter the second number");
            string input2 = Console.ReadLine();
            result = Double.TryParse(input2, out num2);
            if(!result)
            {
                Console.WriteLine("please enter the again");
                return;
            }
            Console.WriteLine("");
            Console.WriteLine("Enter \n.Add , \n.Subtract , \n.Divide");
            CalculateFactory calculate = new CalculateFactory();
            ICalculate obj = calculate.GetCalculation(Console.ReadLine());
            obj.Calculate(num1, num2);
        }
    }
}
