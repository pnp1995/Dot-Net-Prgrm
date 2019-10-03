using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {
      Utility algorithmUtilityobj = new Utility();
       

        public void Callsort()
        {
            try
            {
                Console.WriteLine("enter the length of an array");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the element in array");
                string[] arr = new string[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = (Console.ReadLine());
                }
                Console.WriteLine("Entered string");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
                Console.WriteLine();
               // algorithmUtilityobj.Merge(string []arr, 0, arr.Length - 1);
                Console.WriteLine("After sorting");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
