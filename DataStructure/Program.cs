// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
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
    /// Program is a class i have created static method
    /// </summary>
    class Program
    {
     /// <summary>
    /// static method
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choice;
            
            Console.WriteLine("1.UnOrderedList\n2.OrderedList\n3.BalancedParenthesis\n4.BankingCashCounter\n5.PalindromeCheckers\n6.HashingFunction");
            Console.WriteLine("7.BinarySearchTree\n8.PrimeNumbers\n9.Calender\n10.PrimeAnagram\n11.primeAnagramStack\n12.AnagramQueue\n13.CalenderWeek");
            Console.WriteLine("Enter your Choice ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    UnorderedList unordered = new UnorderedList();
                    unordered.Unordered();
                    break;
                case 2:
                    OrderedList ordered = new OrderedList();
                    ordered.Ordered();
                    break;
                case 3:
                    BalancedParentheses balanced = new BalancedParentheses();
                    balanced.parentheses();
                    break;
                case 4:
                    BankingCashCounter banking = new BankingCashCounter();
                    banking.CashCounter();
                    break;
                case 5:
                    PalindromeChecker palindrome = new PalindromeChecker();
                    palindrome.Checker();
                    break;
                case 6:
                    HasingFile hasingFile = new HasingFile();
                    hasingFile.Demo();
                    break;
                case 7:
                    BinarySearchTree.BinaryTree();
                    break;
                case 8:
                    PrimeNumbers numbers = new PrimeNumbers();
                    numbers.Prime();
                    break;
                case 9:
                    Calender.PrintCalender();
                    break;
                case 10:
                    PrimeAnagram prime = new PrimeAnagram();
                    prime.Numbers();
                    break;
                case 11:
                    PrimeAnagramStack anagramStack = new PrimeAnagramStack();
                    anagramStack.AnagramStack();
                    break;
                case 12:
                    AnagramQueue anagram = new AnagramQueue();
                    anagram.PrimeAnagramQueue();
                    break;
                case 13:
                    CalenderWeek calender = new CalenderWeek();
                    calender.WeekDay();
                    break;
            }
        }
    }
}
