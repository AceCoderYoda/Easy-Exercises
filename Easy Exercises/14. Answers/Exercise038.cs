#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise038.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise038
    {
        public static void Main()
        {
            var str1 = "Kill two birds with one stone";
            var str2 = "birds";
            var x = str1.Contains(str2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                str2, str1, x);
            if (x)
            {
                var index = str1.IndexOf(str2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",
                        str2, index + 1);
            }
        }
    }
}