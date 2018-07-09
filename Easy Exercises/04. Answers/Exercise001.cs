#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise001.cs
// Created On    ::    09/07/2018 09:29
// Altered On    ::    09/07/2018 09:29
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise001
    {
        public static void Main()
        {
            Console.Write("Input letter: ");
            var letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            var letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            var letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
        }
    }
}