#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise009.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise009
    {
        public static bool chkprime(int num)
        {
            for (var i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input a number : ");
            var n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}