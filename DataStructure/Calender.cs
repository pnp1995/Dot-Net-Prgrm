// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Calender.cs" company="Bridgelabz">
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
    /// calender is a class we perform the operation to get the calender of specified month and year
    /// </summary>
    class Calender
    {
        /// <summary>
        /// Prints the calender.
        /// </summary>
        public static void PrintCalender()
        {
            int month = 0, year = 0;
            bool ValidationforMonth = true;
            try
            {
                while (ValidationforMonth)
                {
                    Console.WriteLine("enter the month in Number");
                    string stringMonth = Console.ReadLine();
                    if (utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }
                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }
                    ValidationforMonth = false;
                }
                bool validationforYear = true;
                while (validationforYear)
                {
                    Console.WriteLine("enter the year");
                    string stringYear = Console.ReadLine();
                    if (utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Year");
                        continue;
                    }
                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("invalid year");
                        Console.Read();
                        return;
                    }
                    year = Convert.ToInt32(stringYear);
                    validationforYear = false;
                } 
                //// storing the month in an array.
                string[] monthName = { " ", "january", "February", "march", "April", "may", "june", "july", "august", "september", "october", "november", "december" };
                //// storing the number of day in a month in an array
                int[] numerofday = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////  for leapyear check
                if (month == 2 && utility.isLeapYear(year))
                {
                    numerofday[month] = 29;
                }
                Console.WriteLine("\t\t\t" + monthName[month] + " " + year);
                Console.WriteLine();
                Console.WriteLine("su\tM\tTu\tW\tTh\tF\tSa");
                //// Week days where month start
                int d = utility.day(month, 1, year);
                ////print the calender.
                for (int j = 0; j < d; j++)
                {
                    Console.Write(" \t ");
                }
                //// Condition to print the calender.
                for (int i = 1; i <= numerofday[month]; i++)
                {
                    Console.Write(i + " \t ");
                    if (((i + d) % 7 == 0) || (i == numerofday[month]))
                                                                                                                                                     Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }   

    }
}
