#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise004.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise004
    {
        public static int SpaceCount(string str)
        {
            var spcctr = 0;
            string str1;
            for (var i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }

            return spcctr;
        }

        public static void Main()
        {
            string str2;
            Console.Write("\n\nFunction to count number of spaces in a string :\n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();
            Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
        }
    }
}