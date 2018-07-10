#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise007.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise007
    {
        public static void Main()
        {
            string str;
            int alp, digit, splch, i, l;
            alp = digit = splch = i = 0;


            Console.Write("\n\nCount total number of alphabets, digits and special characters :\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;

            /* Checks each character of string*/

            while (i < l)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                    alp++;
                else if (str[i] >= '0' && str[i] <= '9')
                    digit++;
                else
                    splch++;

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alp);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
        }
    }
}