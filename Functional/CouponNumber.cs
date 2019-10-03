// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CouponNumber.cs" company="Bridgelabz">
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
    /// CoupanNumber is class name
    /// </summary>
     class CouponNumber
    {
        /// <summary>
        /// Coupans this instance.
        /// </summary>
      public void Coupan()
        {
            Console.WriteLine("Enter n coupon number");

            //// number of card type
            int n =Convert.ToInt32(Console.ReadLine());

            //// boolean array store only distinct numbers while avoiding duplicates
            Boolean[] Collection = new Boolean[n];

            ////  total number of cards collected
            int count = 0;
            int distinct = 0;
            Random random = new Random();

            ////// repeatedly choose a random card and check whether it's a new one
            while (distinct<n)
            {
                int i = Convert.ToInt32(random.Next(n));
                count++;

                if (!Collection[i])
                {
                distinct++;
               Console.WriteLine("total distinct number are" + distinct);
               Collection[i] = true;
            }
          }
               Console.WriteLine("total random number needed to make all distinct");
               Console.WriteLine(count);
       }
    
    }

}