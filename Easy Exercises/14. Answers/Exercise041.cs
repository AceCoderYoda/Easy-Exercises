#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise041.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise041
    {
        public static void Main()
        {
            string[] strings =
            {
                "Actions speak louder than words", "Hello!", "Python.",
                "PHP.", "random"
            };
            foreach (var value in strings)
            {
                var endsInPeriod = value.EndsWith(".");
                Console.WriteLine();
                Console.WriteLine("'{0}' ends in a period: {1}",
                    value, endsInPeriod);
            }
        }
    }
}