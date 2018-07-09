#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise061.cs
// Created On    ::    09/07/2018 09:11
// Altered On    ::    09/07/2018 09:11
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise061
    {
        public static int[] sort_numbers(int[] arra)
        {
            var num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();
            var ctr = 0;

            return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }

        public static void Main()
        {
            var x = sort_numbers(new[] {-5, 236, 120, 70, -5, -5, 698, 280});
            foreach (var item in x) Console.WriteLine(item.ToString());
        }
    }
}