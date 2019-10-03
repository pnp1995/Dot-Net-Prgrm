using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertioonSort
    {
        public void Sort()
        {
            Console.WriteLine("Enter the length of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            //// intilizing of an string array
            string[] s = new string[n];
            Console.WriteLine("Enter the string");
            ////For loop for reading the element in the array
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = i + 1; j >0; j--)
                {
                    if ((s[j-1].CompareTo(s[j]) > 0))
                    {
                        string temp = s[j-1];
                        s[j-1] = s[j];
                        s[i] = temp;
                    }
                }
            }
            Console.WriteLine("After insertion sort:");
            for( int i =0;i<n;i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}