#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise006.cs
// Created On    ::    09/07/2018 07:53
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise006
    {
        public static void Main()
        {
            Console.Write("Input the first number to multiply: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            var num3 = Convert.ToInt32(Console.ReadLine());

            var result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                num1, num2, num3, result);
        }
    }
}