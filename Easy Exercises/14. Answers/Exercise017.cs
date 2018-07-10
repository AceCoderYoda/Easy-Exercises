#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise017.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise017
    {
        public static void Main()
        {
            string str1;
            string findstr;
            Console.Write("\n\nSearch the position of a substing within a string :\n");
            Console.Write("-------------------------------------------------------\n");
            Console.Write("Input a String: ");
            str1 = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            findstr = Console.ReadLine();
            var index = str1.IndexOf(findstr);
            if (index < 0)
                Console.WriteLine("The substring no found  in the given string \n");
            else
                Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                    findstr, str1, index);
        }
    }
}