#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise005.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise005
    {
        private static void Main(string[] args)
        {
            string str;

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                group x by x
                into y
                select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var ArrEle in FreQ)
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
        }
    }
}