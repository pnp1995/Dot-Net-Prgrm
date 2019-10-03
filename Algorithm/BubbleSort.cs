// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BubbleSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{/// <summary>
/// BubbleSort is class which i have created to sort the elements by using sorts the elements
/// </summary>
    class BubbleSort
    {
        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void sort()
        {
            Console.WriteLine("Enter the length of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            //// intilizing of an integer array
            int[] arr = new int[n];
            Console.WriteLine("Enter the element in array");
            ////For loop for reading the element in the array
            for(int i =0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
           }
            int temp = 0;
            ////For loop is used for recursion
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        //// condition for swapping element
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After bubble sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}