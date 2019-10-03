// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    namespace Algorithm
    {
        class Program
        {
            static void Main(string[] args)
            {
                int choice;
                Console.WriteLine("1.Anagram\n2.PrimeNumber\n3.QuestionNumber\n4.BubbleSort");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Anagram ana = new Anagram();
                        ana.AreAnagram();
                        break;
                    case 2:
                       
                        PrimePalindromic prime = new PrimePalindromic();
                        prime.Prime();
                        break;
                    case 3:
                        QuestionNumber question = new QuestionNumber();
                        question.Question_Game();
                        break;
                    case 4:
                        BubbleSort bubble = new BubbleSort();
                        bubble.sort();
                        break;
                }
            }
        }
    }
}