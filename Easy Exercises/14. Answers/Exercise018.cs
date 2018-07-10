#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise018.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise018
    {
        private static void Main()
        {
            Console.Write("\n\nCheck whether a character is alphabet or not and if so, check for case :\n");
            Console.Write("-----------------------------------------------------------------------------\n");
            Console.Write("Input a character: ");
            var ch = (char) Console.Read();
            if (char.IsLetter(ch))
                if (char.IsUpper(ch))
                    Console.WriteLine("\nThe character is uppercase.\n");
                else
                    Console.WriteLine("\nThe character is lowercase.\n");
            else
                Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
        }
    }
}