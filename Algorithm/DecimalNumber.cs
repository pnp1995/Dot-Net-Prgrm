// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DecimalNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// ---------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DecimalNuber is a class i have created binaryNumber method
    /// </summary>
    class DecimalNumber
    {
        /// <summary>
        /// Binaries the number.
        /// </summary>
        public void BinaryNumber()
        {
            int i;
           
            Console.WriteLine("enter the value of n");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] a = new int[10];
            for (i = 0; n >0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Converting Decimail no. ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

        }

    }
}
