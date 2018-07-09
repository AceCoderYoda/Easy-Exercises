#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise054.cs
// Created On    ::    09/07/2018 09:04
// Altered On    ::    09/07/2018 09:04
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise054
    {
        public static int CenturyFromYear(int year)
        {
            return year / 100 + (year % 100 == 0 ? 0 : 1);
        }

        public static void Main()
        {
            Console.WriteLine(CenturyFromYear(1799) == 18);
            Console.WriteLine(CenturyFromYear(1900) == 19);
            Console.WriteLine(CenturyFromYear(1901) == 19);
            Console.WriteLine(CenturyFromYear(1901) == 20);
            Console.WriteLine(CenturyFromYear(1806) == 19);
            Console.WriteLine(CenturyFromYear(1568) == 20);
            Console.WriteLine(CenturyFromYear(2010) == 21);
        }
    }
}