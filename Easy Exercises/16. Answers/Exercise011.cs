#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise011.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise011
    {
        private static void Main()
        {
            decimal f;
            Console.Write("\n\nRecursive Function : To find the factorial of a given number :\n");
            Console.Write("------------------------------------------------------------------\n");
            Console.Write("Input a number : ");
            var num = Convert.ToInt32(Console.ReadLine());
            f = Factorial(num);
            Console.WriteLine("The factorial of {0}! is  {1}", num, f);
        }

        private static decimal Factorial(int n1)
        {
            // The bottom of the recursion
            if (n1 == 0)
                return 1;
            // Recursive call: the method calls itself
            return n1 * Factorial(n1 - 1);
        }
    }
}