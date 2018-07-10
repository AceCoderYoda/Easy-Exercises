#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise015.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise015
    {
        public static void Main()
        {
            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\n\nReplace lowercase characters by uppercase and vice-versa :\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // Converts string into char array.

            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (char.IsLower(ch)) // check whether the character is lowercase
                    Console.Write(char.ToUpper(ch)); // Converts lowercase character to uppercase.
                else
                    Console.Write(char.ToLower(ch)); // Converts uppercase character to lowercase.
            }

            Console.Write("\n\n");
        }
    }
}