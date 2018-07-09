#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise023.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise023
    {
        public static void Main()

        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[50, 50];


            Console.Write("\n\nFind sum of right diagonals of a matrix :\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }


            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n", sum);
        }
    }
}