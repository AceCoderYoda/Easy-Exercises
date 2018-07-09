#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise042.cs
// Created On    ::    09/07/2018 08:50
// Altered On    ::    09/07/2018 08:50
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise042
    {
        public static void Main()
        {
            Console.Write("Input a string: ");
            var str = Console.ReadLine();
            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
        }
    }
}