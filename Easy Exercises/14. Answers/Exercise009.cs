#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise009.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise009
    {
        public static void Main()
        {
            string str;
            int i, len, vowel, cons;

            Console.Write("\n\nCount total number of vowel or consonant :\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                    vowel++;
                else if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z') cons++;
            Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
            Console.Write("The total number of consonant in the string is : {0}\n\n", cons);
        }
    }
}