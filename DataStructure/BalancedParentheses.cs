// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BalancedParenthesis.cs" company="Bridgelabz">
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
    class BalancedParentheses
    {
        utility utility = new utility();
        /// <summary>
        /// Parentheseses this instance.
        /// </summary>
        public void parentheses()
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\admin\Desktop\Parentheses.txt");
                String[] arr = text.Split(' ');
                Console.WriteLine(arr.Length);
                for(int i = 0; i<arr.Length;i++)
                {
                    if (arr[i] == "(")
                    {
                        utility.AddString("(");
                    }
                    else if(arr[i] == ")")
                    {
                        utility.DeleteString("(");
                    }
                }
                utility.IsEmpty();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
