#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise019.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise019
    {
        public static void Main()
        {
            string str1;
            string findstring;
            var strt = 0;
            var cnt = -1;
            var idx = -1;

            Console.Write("\n\nFind the number of times a specific string appears in a string :\n");
            Console.Write("--------------------------------------------------------------------\n");

            Console.Write("Input the original string : ");
            str1 = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();


            while (strt != -1)
            {
                strt = str1.IndexOf(findstring, idx + 1);
                cnt += 1;
                idx = strt;
            }

            Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);
        }
    }
}