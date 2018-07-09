#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise005.cs
// Created On    ::    09/07/2018 07:46
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise005
    {
        public static void Main(string[] args)
        {
            Console.Write("\nInput the First Number : ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            var number2 = int.Parse(Console.ReadLine());
            var temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}