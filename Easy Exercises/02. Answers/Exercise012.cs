#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise012.cs
// Created On    ::    09/07/2018 08:01
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise012
    {
        public static void Main()
        {
            Console.WriteLine("Enter a digit: ");
            var num = Convert.ToInt32(Console.ReadLine());

            // Part A: "num num num num" using Write
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            // Part B: "numnumnumnum" using Write
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            // Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}