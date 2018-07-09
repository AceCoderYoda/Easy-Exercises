#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise011.cs
// Created On    ::    09/07/2018 08:00
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise011
    {
        public static void Main()
        {
            Console.Write("Enter your age ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
        }
    }
}