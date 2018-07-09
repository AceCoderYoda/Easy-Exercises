#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise016.cs
// Created On    ::    09/07/2018 10:09
// Altered On    ::    09/07/2018 10:14
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise016
    {
        private static void Main(string[] args)
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
                Console.Write("You entered a number, Please enter an alpahbet.");
            else
                switch (ch)
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            Console.ReadKey();
        }
    }
}