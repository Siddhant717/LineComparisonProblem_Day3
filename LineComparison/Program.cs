﻿using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x3 :");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y3 :");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x4:");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y4:");
            double y4 = Convert.ToDouble(Console.ReadLine());


            double x = (x2 - x1) * (x2 - x1);
            double y = (y2 - y1) * (y2 - y1);
            double z = x + y;
            double length1 = Math.Sqrt(z);
            Console.WriteLine("Length of the line is" + length1);

            double a = (x4 - x3) * (x4 - x3);
            double b = (y4 - y3) * (y4 - y3);
            double c = a + b;
            double length2 = Math.Sqrt(c);
            Console.WriteLine("Length of the line is" + length2);

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Both the lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("Line1 is smaller than line2");
            }
        }
    }
}
