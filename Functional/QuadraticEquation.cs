
namespace BasicProgram.functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// QuadraticEquation is class 
    /// </summary>
    class QuadraticEquation
    {
        public void Qudratic()
        {
            Console.WriteLine("Enter the Coefficients");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double root1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            double root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine("The roots1 are:" + root1);
            Console.WriteLine("The roots2 are:" + root2);
        }
    }
}
