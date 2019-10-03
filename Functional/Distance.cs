// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BasicProgram.functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;  
    /// <summary>
    /// distance is the class where i have calculated method.
    /// </summary>
    class Distance
    {
        Utility utility = new Utility();


        /// <summary>
        /// calculate is method
        /// </summary>
        public void Calculate()
        {

            //// Reading of  x and y from user for 1st coordinate number
            Console.WriteLine("Enter first coordinate number");
            double x = Convert.ToDouble(Console.ReadLine()); 
            double y = Convert.ToDouble(Console.ReadLine());
            //Console.Write("for a ");
           // double x = utility.CallDouble();
            //// Reading of  x and y from user for 2nd coordinate number
            Console.WriteLine("Enter Second coordinate number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            //// squareroot of (x-a)^2
            double root1 = Math.Pow((x - a), 2);

            //// squareroot of (y-b)^2
            double root2 = Math.Pow((y - b), 2);
            if (x > a && y > b)
            {
                //// squareroot of (x-a)^2+(y-b)^2
                double dist = Math.Sqrt(root1+root2);
                Console.WriteLine("Distance is :" + dist);

            }
        }
    }
}
