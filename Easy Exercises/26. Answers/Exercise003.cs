#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise003.cs
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
    public class Exercise003
    {
        public static void Main()
        {
            var fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName)) File.Delete(fileName);
                Console.Write("\n\n Create a file in the disk if it is exists:\n");
                Console.Write("-----------------------------------------------\n");
                // Create the file.
                using (var fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}