#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise057.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise057
    {
        public static void Main()
        {
            string str, str1 = "";
            int i, l;


            Console.Write("\n\n");
            Console.Write("Print a string in reverse order:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  A String : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--) str1 = str1 + str[i];

            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
            Console.Write("\n");
        }
    }
}