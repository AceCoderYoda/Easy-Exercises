#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise026.cs
// Created On    ::    09/07/2018 08:33
// Altered On    ::    09/07/2018 08:33
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise026
    {
        public static void Main()
        {
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            var ctr = 0;
            var n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }

                n++;
            }

            Console.WriteLine(sum.ToString());
        }

        public static bool isPrime(int n)
        {
            var x = (int) Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (var i = 2; i <= x; ++i)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}