#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise055.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise055
    {
        public static void Main()
        {
            int decn, q, dn = 0, m, l;
            int tmp;
            int s;

            Console.Write("\n\n");
            Console.Write("Convert a number in decimal to hexadecimal:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  any Decimal number: ");
            decn = Convert.ToInt32(Console.ReadLine());
            q = decn;
            for (l = q; l > 0; l = l / 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                dn = dn * 100 + tmp;
            }

            Console.Write("\nThe equivalent Hexadecimal Number : ");
            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char) s);
            }

            Console.Write("\n\n");
        }
    }
}