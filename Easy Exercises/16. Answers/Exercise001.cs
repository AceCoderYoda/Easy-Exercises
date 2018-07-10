#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise001.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise001
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }

        public static void Main()
        {
            Console.Write("\n\nSee, how to create an user define function :\n");
            Console.Write("------------------------------------------------\n");
            welcome();
            HaveAnice();
            Console.Write("\n");
        }
    }
}