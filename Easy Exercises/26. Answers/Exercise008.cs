#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    26. Answers.Exercise008.cs
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
    public class Exercise008
    {
        public static void Main()
        {
            var fileName = @"mytest.txt";
            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName)) File.Delete(fileName);
                Console.Write("\n\n Append some text to an existing file  :\n");
                Console.Write("--------------------------------------------\n");
                // Create the file.
                using (var fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                }

                using (var sr = File.OpenText(fileName))
                {
                    var s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null) Console.WriteLine(s);
                    Console.WriteLine("");
                }

                using (var file = new StreamWriter(@"mytest.txt", true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }

                using (var sr = File.OpenText(fileName))
                {
                    var s = "";
                    Console.WriteLine(" Here is the content of the file after appending the text : ");
                    while ((s = sr.ReadLine()) != null) Console.WriteLine(s);
                    Console.WriteLine("");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}