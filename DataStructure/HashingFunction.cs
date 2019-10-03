// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HashingFunction.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

  public  class HashingFunction
    {
        utility utility = new utility();
        public int[,] HashList = new int[10, 10];
        /// <summary>
        /// Calculates the hash.
        /// </summary>
        /// <param name="mylist">The mylist.</param>
        /// <returns></returns>
        public int[,] CalculateHash(List<int> mylist)
        {
            foreach (int element in mylist)
            {
                int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;
                if (utility.Remainder(element) == 0)
                {
                    HashList[0, first] = element;
                    first++;
                }
                else if (utility.Remainder(element) == 1)
                {
                    HashList[1, second] = element;
                    second++;
                }
                else if (utility.Remainder(element) == 2)
                {
                    HashList[2, third] = element;
                    third++;
                }
                else if (utility.Remainder(element) == 3)
                {
                    HashList[3, fourth] = element;
                    fourth++;
                }
                else if (utility.Remainder(element) == 4)
                {
                    HashList[4, fifth] = element;
                    fifth++;
                }
                else if (utility.Remainder(element) == 5)
                {
                    HashList[5, sixth] = element;
                    sixth++;
                }
                else if (utility.Remainder(element) == 6)
                {
                    HashList[6, seventh] = element;
                    seventh++;
                }
                else if (utility.Remainder(element) == 7)
                {
                    HashList[7, eighth] = element;
                    eighth++;
                }
                else if (utility.Remainder(element) == 8)
                {
                    HashList[8, nineth] = element;
                    nineth++;
                }
                else if (utility.Remainder(element) == 9)
                {
                    HashList[9, tenth] = element;
                    tenth++;
                }
            }
            return HashList;
        }
    }
    public class HasingFile
    {
        List<int> mylist = new List<int>();
        int[,] arr1 = new int[10, 10];
        public void Demo()
        {
            utility utility = new utility();
            HashingFunction hashingFunction = new HashingFunction();
            string data = File.ReadAllText(@"C:\Users\admin\Desktop\HashList.txt");
            string[] arr = data.Split(",");
            Console.WriteLine("Display list from linked list ");
            int[] numbers = new int[arr.Length];
            for (int n = 0; n < numbers.Length; n++)
            {
                numbers[n] = int.Parse(arr[n]);
            }
            ////foreach loop for traversing throughout list
            foreach (int intData in numbers)
            {
                mylist.Add(intData);
            }
          arr1=  hashingFunction.CalculateHash(mylist);
            Console.WriteLine(" ");
            utility.PrintHashArray(arr1);
            Console.WriteLine("enter  the number which you want");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            utility.SearchInHash(searchNum, arr1);
            Console.ReadKey();
        }

    }
}
       

       
  
