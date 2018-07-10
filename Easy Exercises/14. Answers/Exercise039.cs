#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise039.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise039
    {
        public static void Main()
        {
            var s1 = "JAVA";
            var s2 = "Python";

            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);

            Console.WriteLine("\nAfter String.Copy...");
            s2 = string.Copy(s1);
            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);
            Console.WriteLine("ReferenceEquals: {0}", ReferenceEquals(s1, s2));
            Console.WriteLine("Equals: {0}", Equals(s1, s2));

            Console.WriteLine("\nAfter Assignment...");
            s2 = s1;
            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);
            Console.WriteLine("ReferenceEquals: {0}", ReferenceEquals(s1, s2));
            Console.WriteLine("Equals: {0}", Equals(s1, s2));
        }
    }
}