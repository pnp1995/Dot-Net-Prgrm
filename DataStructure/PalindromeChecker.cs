// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PalindromeChecker.cs" company="Bridgelabz">
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
    /// Palindrome is a class where i have created Checker class.
    /// </summary>
    class PalindromeChecker
    {
        utility utility = new utility();
        /// <summary>
        /// Checkers this instance.
        /// </summary>
        public void Checker()
        {
            try
            {
                Console.WriteLine("Enter the string");
                string word = Console.ReadLine();
                char[] ch = new char[30];
                //// converting string to character.
                ch = word.ToCharArray();
                Console.WriteLine(ch);
                string s1 = " ";
                //// storing the character array to list  by converting them into string
                for (int i = ch.Length - 1; i >= 0; i--)
                {
                   utility.Enqueue(ch[i].ToString());
                    s1 += ch[i];
                   //Console.WriteLine(" ");
                }
                string s2 = " ";
                //// Dequeue of the element
                for(int i = 0; i<ch.Length;i++)
                {
                  utility.Dequeue(ch[i].ToString());
                    s2 += ch[i];
                  //Console.WriteLine(" ");
                }
                //// condition to check the elements added and deleted if same palendrome or not
                if(s1 == s2)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("is not palindrome");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
