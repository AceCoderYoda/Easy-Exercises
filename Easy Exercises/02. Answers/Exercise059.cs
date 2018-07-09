#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise059.cs
// Created On    ::    09/07/2018 09:09
// Altered On    ::    09/07/2018 09:09
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise059
    {
        public static bool test_Increasing_Sequence(int[] int_seq)
        {
            var x = 0;
            for (var i = 0; i < int_seq.Length - 1; i++)
            {
                if (int_seq[i] >= int_seq[i + 1])
                    x++;
                if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
                    x++;
            }

            return x <= 2;
        }

        public static void Main()
        {
            Console.WriteLine(test_Increasing_Sequence(new[] {1, 3, 5, 6, 9}));
            Console.WriteLine(test_Increasing_Sequence(new[] {0, 10}));
            Console.WriteLine(test_Increasing_Sequence(new[] {1, 3, 1, 3}));
        }
    }
}