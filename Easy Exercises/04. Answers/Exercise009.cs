#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise009.cs
// Created On    ::    09/07/2018 09:38
// Altered On    ::    09/07/2018 09:38
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
            char symbol;

            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' ||
                symbol == 'o' || symbol == 'u')
                Console.WriteLine("It's a lowercase vowel.");
            else if (symbol >= '0' && symbol <= '9')
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
        }
    }
}