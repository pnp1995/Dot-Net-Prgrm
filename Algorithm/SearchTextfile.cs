// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SearchTextfile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class SearchTextfile
    {
        Utility utility = new Utility();
        public void TextFile()
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\admin\Desktop\file.txt");
                string[] arr = text.Split(" ");
                foreach (string str in arr)
                Console.WriteLine(str + " ");
                Console.WriteLine("Enter the element to Search");
                string key = Console.ReadLine();
                int first = 0, last = arr.Length - 1;
                utility.BinaryString(arr, first, last, key);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
