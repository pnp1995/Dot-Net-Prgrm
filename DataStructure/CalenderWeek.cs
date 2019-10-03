// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CalenderWeek.cs" company="Bridgelabz">
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
    /// /Calender Week is a class i have created one weekDay method.
    /// </summary>
    class CalenderWeek
    {/// <summary>
    /// WeekDay is instance
    /// </summary>
        public void  WeekDay()
        {
            Console.WriteLine("enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            int day = 1, space = 0;

            int year0 = year - (14 - month) / 12;
            int x = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + x + 31 * month0 / 12) % 7;
            int days = 1;
            Console.WriteLine(day0);
            Console.WriteLine("  " + year + " " + month);
            Console.WriteLine("........");
            //// Switch case to find the no. of day in month.
            switch (month)
            {
                case 1:
                    days = 31;
                    break;
                case 2:
                    days = 28;
                    break;
                case 3:
                    days = 31;
                    break;
                case 4:
                    days = 30;
                    break;
                case 5:
                    days = 31;
                    break;
                case 6:
                    days = 30;
                    break;
                case 7:
                    days = 31;
                    break;
                case 8:
                    days = 31;
                    break;
                case 9:
                    days = 30;
                    break;
                case 10:
                    days = 31;
                    break;
                case 11:
                    days = 30;
                    break;
                case 12:
                    days = 31;
                    break;

                default:
                    Console.WriteLine("no match found");
                    break;
            }
            Console.WriteLine(" " + "sun" + " " + "mon" + " " + "tue" + " " + "wed" + " " + "Thu" + " " + "fri" + " " + "sat");
            for(int i =0; i<7;i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (space < day0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(days);
                        days++;
                    }
                }
            }
        }
    }
}