// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinarySearchTree.cs" company="Bridgelabz">
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
    /// Binary Search tree is a class i have created binary tree method for binary operation.
    /// </summary>
    class BinarySearchTree
    {
        utility utility = new utility();
        /// <summary>
        /// Binaries the tree.
        /// </summary>
        public static void BinaryTree()
        {
            try
            {
                int num = 0;
                bool iterate = true;
                while (iterate)
                {
                    Console.WriteLine("enter the number of element");
                    string element = Console.ReadLine();
                    if (utility.IsNumber(element) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }
                    num = Convert.ToInt32(element);
                    if (num < 0)
                    {
                        Console.WriteLine("element should be greater than 0");
                        continue;
                    }
                    iterate = false;
                }
                int numBinaryTree = utility.CountBinaryTree(num);
                Console.WriteLine("Number possible of binary tree = " + numBinaryTree);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
    

