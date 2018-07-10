#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise011.cs
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
    public class Exercise011
    {
        public static void Main()
        {
            var fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName)) File.Delete(fileName);
                Console.Write("\n\n Read the first line from a file  :\n");
                Console.Write("---------------------------------------\n");
                // Create the file.
                using (var fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" test line 1");
                    fileStr.WriteLine(" test line 2");
                    fileStr.WriteLine(" Test line 3");
                }

                using (var sr = File.OpenText(fileName))
                {
                    var s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null) Console.WriteLine(s);
                    Console.WriteLine("");
                }

                Console.Write("\n The content of the first line of the file is :\n");
                if (File.Exists(fileName))
                {
                    var lines = File.ReadAllLines(fileName);
                    Console.Write(lines[0]);
                }

                Console.WriteLine();
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}