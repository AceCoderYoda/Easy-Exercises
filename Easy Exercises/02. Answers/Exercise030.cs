#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise030.cs
// Created On    ::    09/07/2018 08:38
// Altered On    ::    09/07/2018 08:38
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
        public static void Main()
        {
            var hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            var decValue = int.Parse(hexval, NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }
    }
}