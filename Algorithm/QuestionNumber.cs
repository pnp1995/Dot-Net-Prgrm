
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class QuestionNumber
    {
        public void Question_Game()
        {
            int n;
            Console.WriteLine("enter value power of number upto n");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] =Convert.ToInt32( Math.Pow(2, i));
                Console.Write(array[i]+ " ");
            }
            
            char ch;
            int first = 0,last = array.Length - 1;
            Console.WriteLine("Keep 1 no. in your mind donot tell from given list");
            Console.WriteLine("enter 1 if you are done");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 1)
            {
                    Array.Sort(array);
                    while(first<=last)
                    {
                        int mid = (first + last) / 2;
                        Console.WriteLine("is your no. less than or equal to"+ array[mid]+ "?(y/n)");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch == 'y' || ch == 'N')
                        {
                            last = mid;
                            Console.WriteLine("is" + array[mid] + "your number?(y/n)");
                            ch = Convert.ToChar(Console.ReadLine());
                            if (ch == 'y' || ch == 'N')
                            {
                                Console.WriteLine("Number is found" + array[mid]);
                                break;
                            }
                                
                        }
                    else
                    {
                        first = mid;
                        Console.WriteLine("is" + array[mid] + "your number?(y/n)");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch == 'y' || ch == 'N')
                        {
                            Console.WriteLine("Number is found" + array[mid]);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("please click only if you are done to continue");
            }
        }
    }
}
