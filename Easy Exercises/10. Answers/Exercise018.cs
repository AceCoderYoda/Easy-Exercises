#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise018.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise018
    {
        public static void Main()
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}