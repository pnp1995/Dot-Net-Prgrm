// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram.functional
{
    /// <summary>
    /// Replace string is class name 
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Run is method
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Enter username");
            string str1 = Console.ReadLine();
            string str2 = "Hello  << UserName >>  How are you?";

            Console.WriteLine(str2.Replace(" << UserName >>", str1));
        }

    }
}
