// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Sumofinteger.cs" company="Bridgelabz">
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
    /// Sumofinteger is class
    /// </summary>
    class Sumofinteger
    {
        /// <summary>
        /// Sums this instance.
        /// </summary>
        public void Sum()
        {
            Console.WriteLine("Enter the number n");
            int n = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [n];
            for(int i = 0; i<n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            for (int i = 0; i<array.Length-1; i++)
            {
                for(int j =i+1; j< array.Length - 1; j++)
                {
                    for (int k = j+1; k< array.Length - 1; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine("triplets are :" + array[i] + " " + array[j] + " " + array[k]);
                        }
                    }
                }
            }
         }
    }
}
