#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise034.cs
// Created On    ::    09/07/2018 08:42
// Altered On    ::    09/07/2018 08:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise034
    {
        private static void Main(string[] args)
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.WriteLine(str.Length < 6 && str.Equals("Hello") || str.StartsWith("Hello") && str[5] == ' ');
        }
    }
}