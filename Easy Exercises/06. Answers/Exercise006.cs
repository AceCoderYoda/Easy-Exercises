#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise006.cs
// Created On    ::    09/07/2018 09:50
// Altered On    ::    09/07/2018 09:50
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise006
    {
        public static void Main()
        {
            int m, n;
            Console.Write("\n\n");
            Console.Write("Display the value of n is 1,0 and -1 for the value of er m:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  value of m :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.Write("The value of m = {0} \n", m);
            Console.Write("The value of n = {0} \n\n", n);
        }
    }
}