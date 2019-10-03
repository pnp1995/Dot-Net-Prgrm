// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Gambler.cs" company="Bridgelabz">
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
/// Gambller is classname
/// </summary>
    class Gambler
    {
        /// <summary>
        /// Games this instance.
        /// </summary>
        //// <summary>
    public void game()
        {
                //// asks for input of trail,stake and goal
        
            Console.WriteLine("Enter Stake:");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter goal:");
            int goal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number:");
            double n = Convert.ToInt32(Console.ReadLine());

            double win = 0;
            double loss = 0;
            //created object to use method of random class
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                //NextDouble is a method to generate random number
                double ran = r.NextDouble();
                if (ran > 0.5)
                {
                    win++;
                    // terminate the goal when he reaches goal
                    if (stake == goal)
                        break;
                }
                else
                {
                    loss++;
                }
            }
            //calculation for percentage of win or loss
            
                double winsper = win/n*100;
                double lossper = loss/n*100;

                Console.WriteLine("win");
                Console.WriteLine("winsper");
                Console.WriteLine("lossper");

            }
        }
    }
