#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise012.cs
// Created On    ::    10/07/2018 11:20
// Altered On    ::    10/07/2018 11:25
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.IO;

#endregion

namespace Easy_Exercises
{
    public class Exercise012
    {
        private static void Main()
        {
            var fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;

            Console.Write("\n\n Create and read the last line of a file  :\n");
            Console.Write("-----------------------------------------------\n");

            if (File.Exists(fileName)) File.Delete(fileName);
            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            File.WriteAllLines(fileName, ArrLines);
            Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                Console.WriteLine(" {0}", lines[n - 1]);
            }

            Console.WriteLine();
        }
    }
}