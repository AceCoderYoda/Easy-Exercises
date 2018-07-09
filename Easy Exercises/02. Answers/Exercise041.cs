#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise041.cs
// Created On    ::    09/07/2018 08:48
// Altered On    ::    09/07/2018 08:49
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise041
    {
        public static void Main()
        {
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            var str = Console.ReadLine();
            var count = str.Count(s => s == 'e');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);
        }
    }
}