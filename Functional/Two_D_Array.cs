// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Two_D_Array.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BasicProgram.functional
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Two_D_Array is a class where i define integer array double array, boolean array and printing an element
    /// </summary>
    public class Two_D_Array
    {
        Utility utility = new Utility();
        /// <summary>
        /// Arrays this instanceand print the output using switch cases
        /// </summary>
        public void Array()
        {
          
            Console.WriteLine("Enter number of rows");
            ////redaing number of rows from the user
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Column");

            ////redaing number of column from the user
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] intArray = new int[row, column];
            double[,] doubleArray = new double[row, column];
            Boolean[,] BooleanArray = new Boolean[row, column];
            Console.WriteLine("1.Integer Array \n2.Double Array \n3.Boolean Array");

            int choice = Convert.ToInt32(Console.ReadLine());
            //// switch case to excute code faster
            switch (choice)
            {
                case 1:
                    intArray = utility.CallTwoDimArray(row,column);
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(intArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                 case 2:
                        doubleArray = utility.Call(row, column);
                    
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(doubleArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    BooleanArray = utility.CallBool(row, column);
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(BooleanArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                    default:

                    Console.WriteLine("Enter correct number ");
                   Convert.ToInt32(Console.ReadLine());
                    break;

            }
        }
    }
}