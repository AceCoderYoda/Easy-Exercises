#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise011.cs
// Created On    ::    09/07/2018 10:05
// Altered On    ::    09/07/2018 10:14
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise011
    {
        public static void Main()
        {
            int a, b, c;

            double d, x1, x2;
            Console.Write("\n\n");
            Console.Write("Calculate root of Quadratic Equation :\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root root2= {0}\n", x2);
            }
            else
            {
                Console.Write("Root are imeainary;\nNo Solution. \n\n");
            }
        }
    }
}