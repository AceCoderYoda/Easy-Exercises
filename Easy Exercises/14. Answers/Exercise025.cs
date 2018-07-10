#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise025.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Globalization;
using System.Threading;

#endregion

namespace Easy_Exercises
{
    public class Exercise025
    {
        public static void Main()
        {
            string[] cultureNames = {"en-AU", "sv-SE"};
            string[] strs1 =
            {
                "case", "encyclopedia",
                "encyclopedia", "Archeology"
            };
            string[] strs2 =
            {
                "Case", "encyclopedia",
                "encyclopedia", "ARCHEOLOGY"
            };
            var comparisons = (StringComparison[]) Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (var ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                            strs2[ctr], comparison,
                            string.Equals(strs1[ctr], strs2[ctr], comparison));

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}