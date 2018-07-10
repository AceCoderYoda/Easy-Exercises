#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise007.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise007
    {
        private static void Main(string[] args)
        {
            var nums = {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};

            Console.Write("\nLINQ : Display numbers, number*frequency and frequency : ");
            Console.Write("\n-------------------------------------------------------\n");
            Console.Write("The numbers in the array are : \n");
            Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


            var m = from x in nums
                group x by x
                into y
                select y;
            Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
            Console.Write("------------------------------------------------\n");

            foreach (var arrEle in m) Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            Console.WriteLine();
        }
    }
}