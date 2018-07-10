#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise003.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise003
    {
        private static void Main(string[] args)
        {
            // code from DevCurry.com
            var arr1 = new[] {3, 9, 2, 8, 6, 5};

            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from int Number in arr1
                let SqrNo = Number * Number
                where SqrNo > 20
                select new {Number, SqrNo};

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}