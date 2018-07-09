#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise032.cs
// Created On    ::    09/07/2018 08:40
// Altered On    ::    09/07/2018 08:40
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise032
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            var str = Console.ReadLine();
            if (str.Length > 4)
                Console.WriteLine(str.Length < 4
                    ? str + str + str
                    : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) +
                      str.Substring(str.Length - 4));
        }
    }
}