#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise012.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise012
    {
        private static void Main(string[] args)
        {
            Console.Write("\nLINQ : Find the uppercase words in a string : ");
            Console.Write("\n----------------------------------------------\n");

            string strNew;

            Console.Write("Input the string : ");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            Console.Write("\nThe UPPER CASE words are :\n ");
            foreach (var strRet in ucWord) Console.WriteLine(strRet);
            Console.ReadLine();
        }

        private static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                .Where(x => string.Equals(x, x.ToUpper(),
                    StringComparison.Ordinal));

            return upWord;
        }
    }
}