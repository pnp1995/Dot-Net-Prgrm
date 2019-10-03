
namespace BasicProgram.functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Utility is class
    /// </summary>
    public class Utility
    {          
        public int[,] CallTwoDimArray(int row, int column)
        {
            int[,] intArray = new int[row, column];
            Console.WriteLine("Enter integer array element");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    intArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
              
            }
            return intArray;
        }
        public double[,] Call(int row ,int column)
        {
            double[,] doubleArray = new double[row, column];
            Console.WriteLine("Enter doble aray element");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    doubleArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return doubleArray;
        }

        public Boolean[,] CallBool(int row, int column)
        {
            Boolean[,] BooleanArray = new Boolean[row, column];
            Console.WriteLine("Enter double aray element");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    BooleanArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }
            return BooleanArray;
        }
        public double CallDouble()
        {
            Console.WriteLine("enter the double value");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
    }
}
