// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
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
    /// Anagram is class i have created a AreAnagarm method.
    /// </summary>
    class Anagram
    {
        /// <summary>
        /// Ares the anagram.
        /// </summary>
        public void AreAnagram()
        {
            Console.WriteLine("Enter the string 1 ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the string 2");
            string str2 = Console.ReadLine();

            if (str1.Length == str2.Length)
            {
                int count = 0;
                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();

                //// Sorting  the array.
                Array.Sort(ch1);
                Console.WriteLine(ch1);
                Array.Sort(ch2);
                Console.WriteLine(ch2);

                for (int i = 0; i < ch1.Length; i++)
                {
                    if (ch1[i] == ch2[i])
                    {
                        count++;
                    }
                }
                    if (count == str1.Length)
                    {
                        Console.WriteLine(" is Anagram");
                    }
                else
                {
                    Console.WriteLine(" Not Anagram");
                }

            }
            
            else
            {
                Console.WriteLine("String entered should be same");
            }

            
        }
    }
}
