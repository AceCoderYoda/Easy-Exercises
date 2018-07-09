#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise035.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise035
    {
        public static void Main()
        {
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("\n\n");
            Console.Write("Display the first n terms of fibonacci series:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }

            Console.Write("\n");
        }
    }
}