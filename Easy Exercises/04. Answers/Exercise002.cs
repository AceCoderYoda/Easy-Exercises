#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise002.cs
// Created On    ::    09/07/2018 09:31
// Altered On    ::    09/07/2018 09:31
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void Main()
        {
            Console.Write("Input a number: ");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var height = width;
            for (var row = 0; row < height; row++)
            {
                for (var column = 0; column < width; column++) Console.Write(num);

                Console.WriteLine();
                width--;
            }
        }
    }
}