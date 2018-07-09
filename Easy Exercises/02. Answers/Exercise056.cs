#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise056.cs
// Created On    ::    09/07/2018 09:07
// Altered On    ::    09/07/2018 09:07
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise056
    {
        public static int SumMatrixElements(int[][] myMatrix)
        {
            var x = 0;
            for (var i = 0; i < myMatrix[0].Length; i++)
            for (var j = 0; j < myMatrix.Length && myMatrix[j][i] > 0; j++)
                x += myMatrix[j][i];

            return x;
        }

        public static void Main()
        {
            Console.WriteLine(SumMatrixElements(
                new[]
                {
                    new[] {0, 2, 3, 2},
                    new[] {0, 6, 0, 1},
                    new[] {4, 0, 3, 0}
                }));
            Console.WriteLine(SumMatrixElements(
                new[]
                {
                    new[] {1, 2, 1, 0},
                    new[] {0, 5, 0, 0},
                    new[] {1, 1, 3, 10}
                }));
            Console.WriteLine(SumMatrixElements(
                new[]
                {
                    new[] {1, 1},
                    new[] {2, 2},
                    new[] {3, 3},
                    new[] {4, 4}
                }));
        }
    }
}