#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise012.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise012
    {
        public static int Fib(int n1)
        {
            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            return Fib(n1 - 1) + Fib(n1 - 2);
        }

        public static void Main()
        {
            int num;

            Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
            Console.Write("-------------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
        }
    }
}