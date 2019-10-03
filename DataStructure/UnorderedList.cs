// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System.IO;
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UnOrderedList is a class to perform the operation linkedlist 
    /// </summary>
    public class UnorderedList
    {
        utility utility = new utility();
        /// <summary>
        /// Unordered is the instance.
        /// </summary>
        public void Unordered()
        {
            //// try and catch are used to handle the Exception if occured
            try
            {
                ////Reading content from file
                string text = File.ReadAllText(@"C:\Users\admin\Desktop\file.txt");
                string[] arr = text.Split(" ");
                Console.WriteLine("Displayed list from linked list");
                //// this for loop is used to add the dataaccording to the spaces
                for (int i = 0; i < arr.Length; i++)
                {
                    string a = arr[i];
                    Console.WriteLine(arr[i]);
                    utility.AddString(arr[i]);
                }
                Console.WriteLine("Total length of the list:" + arr.Length);
               // Console.WriteLine(" ");
               // Console.WriteLine(" ");
                Console.WriteLine("Enter a words to search");
                string search = Console.ReadLine();
                utility.SearchString(search);
                int r = utility.SearchString(search);
                if (r == 1)
                {
                    Console.WriteLine("Do you want to delete "  + search + " word from the list press 1 for delete or 2 for ignore");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        utility.DeleteString(search);
                        File.WriteAllText(@"C:\Users\admin\Desktop\file.txt", search);
                    }
                    else
                        return;
                }
                else if (r == 0)
                {
                    Console.WriteLine("Do you want to add " + search + " word from the list press 1 for delete or 2 for ignore");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        utility.AddString(search);
                        File.WriteAllText(@"C:\Users\admin\Desktop\file.txt", search);
                        utility.Display();
                    }
                    else
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

