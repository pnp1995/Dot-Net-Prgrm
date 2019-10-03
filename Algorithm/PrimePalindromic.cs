using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimePalindromic
    {
        public void Prime()
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            this.Check(n);
        }
        public void Check(int n)
        {
            int k = 0;
            Console.WriteLine("Prime numbers are:");
            int countPrime = 0;
            int[] array = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = i; j < n - 1 && j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i + " ");
                    array[k++] = i;
                    countPrime++;
                }
            }
            Console.WriteLine("\nPalindrome");
            for (int m = 0; m < countPrime; m++)
            {
                int revNum = 0;
                int num = array[m];
                if (num != 0)
                {
                    if (num > 9)
                        while (num > 0)
                        {
                            int rem = num % 10;
                            revNum = revNum * 10 + rem;
                            num = num / 10;
                        }
                    if (revNum == array[m])
                    {
                        Console.WriteLine("Palindromoe" +" "+ array[m] + " ");
                    }
                }
            }
        }
    }

}
