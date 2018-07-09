#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise038.cs
// Created On    ::    09/07/2018 08:46
// Altered On    ::    09/07/2018 08:46
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise038
    {
        private static void Main(string[] args)
        {
            var str1 = "PHP Tutorial";
            var result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
                result += str1[0];
            if (str1.Length >= 2 && str1[1] == 'H')
                result += str1[1];
            Console.WriteLine(result);
        }
    }
}