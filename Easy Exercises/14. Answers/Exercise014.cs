#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise014.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise014
    {
        public static void Main()
        {
            string str1, str2;
            bool m;

            Console.Write("\n\nCheck whether a given substring is present in the given strig :\n");
            Console.Write("-------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the substring to  search : ");
            str2 = Console.ReadLine();
            m = str1.Contains(str2); // boolean value tapped hare
            if (m) // check boolean value is true or false.
                Console.Write("The substring exists in the string.\n\n");
            else
                Console.Write("The substring is not exists in the string. \n\n");
        }
    }
}