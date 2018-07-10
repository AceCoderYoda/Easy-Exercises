#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise007.cs
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
    public class Exercise007
    {
        private static void Main()
        {
            var fileName = @"mytest.txt";
            string[] ArrLines;
            string str;

            int n, i;

            Console.Write(
                "\n\n Create and write some line of text which does not contain a given string in a line  :\n");
            Console.Write(
                "------------------------------------------------------------------------------------------\n");

            if (File.Exists(fileName)) File.Delete(fileName);
            Console.Write(" Input the string to ignore the line : ");
            str = Console.ReadLine();
            Console.Write(" Input number of lines to write in the file  : ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];

            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            using (var file =
                new StreamWriter(@"mytest.txt"))
            {
                foreach (var line in ArrLines)
                    if (!line.Contains(str)) // write the line to the file If it doesn't contain the string in str
                        file.WriteLine(line);
            }

            using (var sr = File.OpenText(fileName))
            {
                var s = "";
                Console.Write("\n The line has ignored which contain the string '{0}'. \n", str);
                Console.Write("\n The content of the file is  :\n", n);
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null) Console.WriteLine(" {0} ", s);
                Console.WriteLine();
            }
        }
    }
}