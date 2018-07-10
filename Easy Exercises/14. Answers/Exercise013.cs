#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise013.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise013
    {
        public static void Main()
        {
            string str;
            char[] arr1;
            int pos, l, ln, c = 0;

            Console.Write("\n\nExtract a substring from a given string:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            ln = str.Length;
            arr1 = str.ToCharArray(0, ln);

            Console.Write("Input the position to start extraction :");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the length of substring :");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("The substring retrieve from the string is : ");
            while (c < l)
            {
                Console.Write(arr1[pos + c - 1]);
                c++;
            }

            Console.Write("\n\n");
        }
    }
}