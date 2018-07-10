#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise007.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
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
            int n1;
            int exp1;
            Console.Write("\n\nFunction : To calculate the result of raising an integer number to another :\n");
            Console.Write("--------------------------------------------------------------------------------\n");
            Console.Write("Input Base number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Exponent : ");
            exp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ", n1, exp1, PowerRaising(n1, exp1));
        }

        public static int PowerRaising(int num, int exp)
        {
            var rvalue = 1;
            int i;
            for (i = 1; i <= exp; i++)
                rvalue = rvalue * num;
            return rvalue;
        }
    }
}