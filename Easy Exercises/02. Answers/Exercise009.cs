#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise009.cs
// Created On    ::    09/07/2018 07:57
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise009
    {
        public static void Main()
        {
            Console.Write("Enter the First number: ");
            var number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            var number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            var number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            var number4 = Convert.ToDouble(Console.ReadLine());

            var result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
                number1, number2, number3, number4, result);
        }
    }
}