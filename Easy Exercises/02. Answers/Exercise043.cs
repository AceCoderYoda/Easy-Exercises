#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise043.cs
// Created On    ::    09/07/2018 08:51
// Altered On    ::    09/07/2018 08:51
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise043
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            var str = Console.ReadLine();
            Console.WriteLine(test(str));
        }

        public static bool test(string str)
        {
            var ctr = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('w')) ctr++;
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }

            return false;
        }
    }
}