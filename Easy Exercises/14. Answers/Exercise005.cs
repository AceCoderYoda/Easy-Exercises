#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise005.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise005
    {
        public static void Main()
        {
            string str;
            int i, wrd, l;

            Console.Write("\n\nCount the total number of words in a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t') wrd++;

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }
    }
}