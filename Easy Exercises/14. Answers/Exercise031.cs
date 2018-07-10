#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise031.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise031
    {
        public static void Main()
        {
            var str1 = "JAVA";
            var str2 = "python";
            string str;
            int result;

            Console.WriteLine();
            Console.WriteLine("Compare the numeric values of the corresponding Char objects in each string.");
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = string.CompareOrdinal(str1, str2);
            str = result < 0 ? "less than" : (result > 0 ? "greater than" : "equal to");
            Console.Write("String '{0}' is ", str1);
            Console.Write("{0} ", str);
            Console.WriteLine("String '{0}'.", str2);
        }
    }
}