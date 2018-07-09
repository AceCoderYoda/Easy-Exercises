#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise053.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise053
    {
        public static void Main()
        {
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;
            var ocno = 0;

            Console.Write("\n\n");
            Console.Write("Convert binary number into octal:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a binary number :");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                dec = dec + d * p;
                i++;
            }

            /*--------------------------------------------*/
            i = 1;

            for (j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + j % 8 * i;
                i = i * 10;
                n = n / 8;
            }

            Console.Write("\nThe Binary Number : {0}\nThe equivalent Octal  Number : {1} \n\n", n1, ocno);
        }
    }
}