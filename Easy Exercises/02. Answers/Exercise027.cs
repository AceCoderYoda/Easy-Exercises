#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise027.cs
// Created On    ::    09/07/2018 08:34
// Altered On    ::    09/07/2018 08:34
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise027
    {
        public static void Main()
        {
            Console.Write("Input  a number(integer): ");
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }
}