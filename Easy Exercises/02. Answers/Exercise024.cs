#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise024.cs
// Created On    ::    09/07/2018 08:31
// Altered On    ::    09/07/2018 08:31
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise024
    {
        public static void Main()
        {
            var line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            var words = line.Split(new[] {" "}, StringSplitOptions.None);
            var word = "";
            var ctr = 0;
            foreach (var s in words)
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }

            Console.WriteLine(word);
        }
    }
}