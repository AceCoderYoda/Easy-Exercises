#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise030.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise030
    {
        public static void Main()
        {
            int num, r, sum, temp;
            int stno, enno;

            Console.Write("\n\n");
            Console.Write("Find the Armstrong number for a given range of number:\n");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong numbers in given range are: ");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + r * r * r;
                }

                if (sum == num)
                    Console.Write("{0} ", num);
            }

            Console.Write("\n");
        }
    }
}