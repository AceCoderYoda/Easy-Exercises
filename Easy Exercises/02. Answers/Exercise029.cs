#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise029.cs
// Created On    ::    09/07/2018 08:37
// Altered On    ::    09/07/2018 08:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.IO;

#endregion

namespace Easy_Exercises
{
    public class Exercise029
    {
        public static void Main()
        {
            var f = new FileInfo("[path to filename]");
            Console.WriteLine("\nSize of a file: " + f.Length);
        }
    }
}