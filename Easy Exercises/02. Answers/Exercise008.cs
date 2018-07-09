#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise008.cs
// Created On    ::    09/07/2018 07:56
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise008
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            var x = Convert.ToInt32(Console.ReadLine());

            var result = x * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
        }
    }
}