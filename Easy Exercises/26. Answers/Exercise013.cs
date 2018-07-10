#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise013.cs
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
    public class Exercise013
    {
        private static void Main()
        {
            var fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i, l;

            Console.Write("\n\n Read a specific line from a file  :\n");
            Console.Write("----------------------------------------\n");

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

            Console.Write("\n Input which line you want to display  :");
            l = Convert.ToInt32(Console.ReadLine());
            if (l >= 1 && l <= n)
            {
                Console.Write("\n The content of the line {0} of the file {1} is : \n", l, fileName);
                if (File.Exists(fileName))
                {
                    var lines = File.ReadAllLines(fileName);
                    Console.WriteLine(" {0}", lines[l - 1]);
                }
            }
            else
            {
                Console.WriteLine(" Please input the correct line no.");
            }

            Console.WriteLine();
        }
    }
}