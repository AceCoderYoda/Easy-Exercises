#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise021.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise021
    {
        public static void Main()
        {
            //                 01234567
            var str1 = "computer";
            var str2 = "system";
            string str;
            int result;

            Console.WriteLine();
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = string.Compare(str1, 2, str2, 0, 2);
            str = result < 0 ? "less than" : (result > 0 ? "greater than" : "equal to");
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);
        }
    }
}