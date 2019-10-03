// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Tic-Tac-Toe.cs" company="Bridgelabz">
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
    /// Tic_Tac_Toe is a class where i created a mrthod play user and computer gives the input.
    /// </summary>
    class Tic_Tac_Toe
    {
        /// <summary>
        /// Games this instance.
        /// </summary>
        public void game()
        {
            Console.WriteLine("Enter rows and column");
            //// intializing of array with negative integers
            int[,] array = new int[,] { { -1, -2, -3 }, { -4, -5, -6 }, { -7, -8, -9 } };
            //// intializing of coordinate
            int i = 0, x, y;
            //// creating a object of random class
            Random random = new Random();
            //// we have only 9 postion in the board
            while (i < 9)
            {
                //// giving the positive postion turn to the user
                if (i % 2 == 0)
                {
                    do
                    {
                        Console.WriteLine("user enter the coordinates");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0},{1}", x, y);
                    }
                    while (array[x, y] > 0);
                    //// storing of value 1 in that coordinate position in the board
                    array[x, y] = 1;
                    //// check the condition if true then prints user is win
                    //// this. is a keyword which reffereed to current class elements
                    ////calling a win method by using this keyword
                    if (this.Win(array) == 1)
                    {
                        Console.WriteLine("user is winer");
                        break;
                    }
                    i++;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("computer enter the coordinate");
                        //// reading of coordinate randomly using random function
                        x = random.Next(3);
                        y = random.Next(3);
                        Console.WriteLine("{0},{1}",x,y);
                    }
                    while (array[x, y] > 0);
                    //// Storing of value 2 in that coordinate position in the board
                    array[x, y] = 2;
                    if (this.Win(array) == 1)
                    {
                        Console.WriteLine("computer is winner");
                        break;
                    }
                    i++;
                }
                //// if condition true then its draw match
                if (this.Win(array) != 1 && i>3)
                {
                    Console.WriteLine("draw");
                }
            }
        }
        public int Win(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                //// Condition given  to get the winning status on the board
                if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2])
                {
                    return 1;
                }
                else if (array[0, i] == array[1, i] && array[1, i] == array[2, i])
                {
                    return 1;
                }
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                return 1;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
            {
                return 1;
            }
            return 0;
        }

    }

}

