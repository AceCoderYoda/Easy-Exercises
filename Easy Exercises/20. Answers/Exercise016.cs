#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise016.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.IO;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise016
    {
        private static void Main(string[] args)
        {
            var dirfiles = Directory.GetFiles("/home/w3r/abcd/");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
            avgFsize = Math.Round(avgFsize / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avgFsize);
            Console.ReadLine();
        }
    }
}