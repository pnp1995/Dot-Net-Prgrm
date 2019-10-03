// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Temperature.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// /
    /// </summary>
    class Tempreature
    {
        public void Celcious_To_Fahrenhit(double celcious)
        {
            double fahrenhite = (celcious * 9 / 5) + 32;
            Console.WriteLine(fahrenhite);
        }
        public void Fahrenhit_To_Celcious(double fahrenhite)
        {
            double celcious = (fahrenhite - 32) * 5 / 9;
            Console.WriteLine(celcious);

        }
        public void Conversion()
        {
            Console.WriteLine("enter celcius temprature");
            double celcious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter fahrenhite temperature");
            double fahrenhit = Convert.ToDouble(Console.ReadLine());
            Celcious_To_Fahrenhit(celcious);
            Fahrenhit_To_Celcious(fahrenhit);

        }

    }          
}
