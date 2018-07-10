#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise023.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Globalization;

#endregion

namespace Easy_Exercises
{
    public class Exercise023
    {
        public static void Main()
        {
            //                 01234567
            var str1 = "COMPUTER";
            var str2 = "computer";
            string str;
            int result;

            Console.WriteLine();
            Console.WriteLine("\n str1 = '{0}', str2 = '{1}'", str1, str2);
            Console.WriteLine("Ignore case, Turkish culture:");
            result = string.Compare(str1, 4, str2, 4, 2, true, new CultureInfo("tr-TR"));
            str = result < 0 ? "less than" : (result > 0 ? "greater than" : "equal to");
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(4, 2), str2);

            Console.WriteLine();
            Console.WriteLine("Ignore case, invariant culture:");
            result = string.Compare(str1, 4, str2, 4, 2, true, CultureInfo.InvariantCulture);
            str = result < 0 ? "less than" : (result > 0 ? "greater than" : "equal to");
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.\n\n", str2.Substring(4, 2), str2);
        }
    }
}