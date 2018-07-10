#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise008.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise008
    {
        public static int Fibo(int nno)
        {
            var num1 = 0;
            var num2 = 1;

            for (var i = 0; i < nno; i++)
            {
                var temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }

            return num1;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Input number of Fibonacci Series : ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci series of " + n + " numbers is :");
            for (var i = 0; i < n; i++) Console.Write(Fibo(i) + "  ");
            Console.WriteLine();
        }
    }
}