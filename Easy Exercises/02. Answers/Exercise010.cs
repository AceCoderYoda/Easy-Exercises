#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise010.cs
// Created On    ::    09/07/2018 07:59
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise010
    {
        public static void Main()
        {
            Console.Write("Enter first number - ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            var number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                number1, number2, number3, (number1 + number2) * number3, number1 * number2 + number2 * number3);
        }
    }
}