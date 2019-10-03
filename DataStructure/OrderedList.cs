// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OrderedList.cs" company="Bridgelabz">
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
    /// <summary>
    /// OrderedList is a class to perform the operation linkedlist 
    /// </summary>
    class OrderedList
    {
        utility utility = new utility();
        /// <summary>
        /// Ordereds this instance.
        /// </summary>
        public void Ordered()
        {
            //// try and catch are used to handle the Exception if occured
            try
            {
                ////Reading content from file
                string data = File.ReadAllText(@"C:\Users\admin\Desktop\number.txt");
                ////Split the contents according to the spaces.
                string[] arr = data.Split(",");
                ////Sorting of array.
                Array.Sort(arr);
                ////storing the data in the linkedlistand method.
                int[] numbers = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    numbers[i] = int.Parse(arr[i]);
                }
                Console.WriteLine("Displayed list from linked list");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                    utility.AddIntegers(numbers[i]);
                }
                Console.WriteLine("Total length of the list: "+arr.Length);
                Console.WriteLine("Enter the number to search:");
                int search = Convert.ToInt32(Console.ReadLine());
                int r = utility.SearchIntegers(search);
                if (r == 1)
                {
                Console.WriteLine("Do you want to delete " + search + " number in the list press 1 for delete or 2 for ignore");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        utility.DeleteInteger(search);
                        utility.Display();
                    }
                    else

                        return;
                }
                else if (r == 0)
                {
                Console.WriteLine("Do you want to add " + search + " number in the list press 1 for delete or 2 for ignore");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        utility.AddIntegers(search);
                        string output = search.ToString();
                        File.ReadAllText(@"C:\Users\admin\Desktop\number.txt");
                        utility.Display();
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
