#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise030.cs
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
    public class Exercise030
    {
        public static void Main(string[] args)
        {
            var strLow = "xyz";
            var strCap = "XYZ";
            var result = "equal to ";
            var x = 0;
            var pos = 1;

            // The Unicode codepoint for 'b' is greater than the codepoint for 'B'.
            x = string.CompareOrdinal(strLow, pos, strCap, pos, 1);
            if (x < 0) result = "less than";
            if (x > 0) result = "greater than";
            Console.WriteLine("CompareOrdinal(\"{0}\"[{2}], \"{1}\"[{2}]):", strLow, strCap, pos);
            Console.WriteLine("   '{0}' is {1} '{2}'", strLow[pos], result, strCap[pos]);

            // In U.S. English culture, 'b' is linguistically less than 'B'.
            x = string.Compare(strLow, pos, strCap, pos, 1, false, new CultureInfo("en-US"));
            if (x < 0) result = "less than";
            else if (x > 0) result = "greater than";
            Console.WriteLine("Compare(\"{0}\"[{2}], \"{1}\"[{2}]):", strLow, strCap, pos);
            Console.WriteLine("   '{0}' is {1} '{2}'", strLow[pos], result, strCap[pos]);
        }
    }
}