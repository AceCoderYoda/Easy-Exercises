#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise044.cs
// Created On    ::    09/07/2018 08:52
// Altered On    ::    09/07/2018 08:52
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise044
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            var str = Console.ReadLine();
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
                if (i % 2 == 0)
                    result += str[i];
            Console.WriteLine(result);
        }
    }
}