#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.EXercise010.cs
// Created On    ::    09/07/2018 09:39
// Altered On    ::    09/07/2018 09:39
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
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = n1 % 2 == 0
                       && n2 % 2 == 0
                ? true
                : false;

            Console.WriteLine(bothEven ? "there're numbers bothEven" : "there's a number odd");
        }
    }
}