// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// PrimeNumbers is a class 
    /// </summary>
    class PrimeNumbers
    {
        int[,] primeNumber = new int[10, 1000];
        bool prime;
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimeNumbers" /> class.
        /// </summary>
        public PrimeNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j <= (i + 1) * 100; j++)
                {
                   if (IsPrime(j))
                   {
                    primeNumber[i, j] = j;
                   }
                    
                }
            }
        }
        public bool IsPrime(int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                prime = true;
                //// condition for nonprime number
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        public void Prime()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j <= (i + 1) * 100; j++)
                {
                    if (primeNumber[i, j] != 0)
                    {
                        Console.Write(primeNumber[i, j] + " , ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
