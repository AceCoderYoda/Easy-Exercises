#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise003.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise003
    {
        public static void Main()
        {
            string str;
            var l = 0;

            Console.Write("\n\nSeparate the individual characters from a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (l <= str.Length - 1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }

            Console.Write("\n\n");
        }
    }
}