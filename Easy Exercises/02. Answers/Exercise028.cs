#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise028.cs
// Created On    ::    09/07/2018 08:35
// Altered On    ::    09/07/2018 08:35
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;

#endregion

namespace Easy_Exercises
{
    public class Exercise028
    {
        public static void Main()
        {
            var line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            var result = "";
            var wordsList = new List<string>();
            var words = line.Split(new[]
            {
                " "
            }, StringSplitOptions.None);
            for (var i = words.Length - 1; i >= 0; i--) result += words[i] + " ";
            wordsList.Add(result);
            foreach (var s in wordsList) Console.WriteLine("\nReverse String: " + s);
        }
    }
}