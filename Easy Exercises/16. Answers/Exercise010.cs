#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise010.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise010
    {
        public static int SumCal(int n)
        {
            var n1 = Convert.ToString(n);
            var sum = 0;
            for (var i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }

        public static void Main()
        {
            int num;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.Write("--------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));
        }
    }
}