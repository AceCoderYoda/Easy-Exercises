#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise003.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise003
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter a number: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            var n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
        }
    }
}