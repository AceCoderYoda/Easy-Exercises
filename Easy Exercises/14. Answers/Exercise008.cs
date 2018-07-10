#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise008.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise008
    {
        public static void Main()
        {
            string str1;
            int i, l;

            Console.Write("\n\nCopy one string into another string :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();

            l = str1.Length;
            var str2 = new string[l];

            /* Copies string1 to string2 character by character */
            i = 0;
            while (i < l)
            {
                var tmp = str1[i].ToString();
                str2[i] = tmp;
                i++;
            }

            Console.Write("\nThe First string is : {0}\n", str1);
            Console.Write("The Second string is : {0}\n", string.Join("", str2));
            Console.Write("Number of characters copied : {0}\n\n", i);
        }
    }
}