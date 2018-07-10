#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise015.cs
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
    public class Exercise015
    {
        public static void Main()
        {
            string[] arr1 =
                {"aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"};

            Console.Write("\nLINQ : Count File Extensions and Group it : ");
            Console.Write("\n------------------------------------------\n");

            Console.Write("\nThe files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf");
            Console.Write("\n                aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt\n");

            Console.Write("\nHere is the group of extension of the files : \n\n");

            var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(z => z, (fExt, extCtr) => new
                {
                    Extension = fExt,
                    Count = extCtr.Count()
                });

            foreach (var m in fGrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
            Console.ReadLine();
        }
    }
}