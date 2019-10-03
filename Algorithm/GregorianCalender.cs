
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GregorianCalender
    {
        public static void DayofWeek()
        {
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            int year0 = year - (14 - month) / 12;
            int x = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + x + 31*month0 / 12) % 7;

         switch (day0)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;

                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("satuday");
                    break;
                default:
                    Console.WriteLine("null");
                    break;
            }
            }
        }
    }
