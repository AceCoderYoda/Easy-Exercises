#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise002.cs
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
    public class Exercise002
    {
        public static void Main()
        {
            var fileName = @"mytest.txt";
            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName);
            }
            else
            {
                Console.WriteLine(" File does not exist");
                Console.ReadKey();
            }
        }
    }
}