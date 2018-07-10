#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise006.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise006
    {
        public static void interchange(ref int num1, ref int num2)
        {
            int newnum;

            newnum = num1;
            num1 = num2;
            num2 = newnum;
        }

        public static void Main()
        {
            int n1, n2;
            Console.Write("\n\nFunction : To swap the values of two integer numbers :\n");
            Console.Write("----------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            interchange(ref n1, ref n2);
            Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", n1, n2);
        }
    }
}