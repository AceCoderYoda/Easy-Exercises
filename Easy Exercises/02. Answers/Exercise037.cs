#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise037.cs
// Created On    ::    09/07/2018 08:45
// Altered On    ::    09/07/2018 08:45
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise037
    {
        private static void Main(string[] args)
        {
            var str = "PHP Tutorial";
            Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str);
        }
    }
}