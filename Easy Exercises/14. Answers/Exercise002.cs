#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise002.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void Main()
        {
            string str; /* Declares a string of size 100 */
            var l = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("---------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (var chr in str) l += 1;

            Console.Write("Length of the string is : {0}\n\n", l);
        }
    }
}