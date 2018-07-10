#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise002.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void welcome(string name)
        {
            Console.WriteLine("Welcome friend " + name + " !");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }

        public static void Main(string[] args)
        {
            Console.Write("\n\nSee, how to create an user define function with parameters :\n");
            Console.Write("----------------------------------------------------------------\n");
            string str1;

            Console.Write("Please input a name : ");
            str1 = Console.ReadLine();
            welcome(str1);
            HaveAnice();
        }
    }
}