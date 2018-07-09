#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise044.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise044
    {
        public static void Main()
        {
            int i, n1, n2, j, hcf = 1, lcm;
            Console.Write("\n\n");
            Console.Write("Determine the LCM of two numbers using HCF:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input 1st number for LCM: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number for LCM: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            j = n1 < n2 ? n1 : n2;

            for (i = 1; i <= j; i++)
                if (n1 % i == 0 && n2 % i == 0)
                    hcf = i;
            /* We know  the multiplication of HCF and LCM is equivalant
            to the multiplication of these two numbers.*/
            lcm = n1 * n2 / hcf;

            Console.Write("\nThe LCM of {0} and {1} is : {2}\n\n", n1, n2, lcm);
        }
    }
}