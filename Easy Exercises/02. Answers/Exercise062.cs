#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise062.cs
// Created On    ::    09/07/2018 09:12
// Altered On    ::    09/07/2018 09:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise062
    {
        public static string reverse_remove_parentheses(string str)
        {
            var lid = str.LastIndexOf('(');
            if (lid == -1) return str;

            var rid = str.IndexOf(')', lid);

            return reverse_remove_parentheses(
                str.Substring(0, lid)
                + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                + str.Substring(rid + 1)
            );
        }

        public static void Main()
        {
            Console.WriteLine(reverse_remove_parentheses("p(rq)st"));
            Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));
            Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij"));
        }
    }
}