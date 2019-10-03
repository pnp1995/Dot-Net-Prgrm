// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Leapyear.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace BasicProgram.functional
{
    /// <summary>
    /// Leapyear is class name
    /// </summary>
    public class Leapyear
    {
        /// <summary>
        /// Leap is method name
        /// </summary>
        public void Leap()
        {
            //// ask for input of year
            int year;
            Console.Write("Enter year");
            year = int.Parse(Console.ReadLine()); 
            //// take the loop and check the year>1000 
            if (year > 1000)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("leap Year" + year);
                }
                else
                {
                    Console.WriteLine("Not leap Year" + year);
                }
            
            }

            Console.ReadLine();
        }

    }
}
