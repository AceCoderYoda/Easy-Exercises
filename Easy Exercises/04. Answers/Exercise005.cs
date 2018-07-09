#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise005.cs
// Created On    ::    09/07/2018 09:34
// Altered On    ::    09/07/2018 09:34
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise005
    {
        public static void Main()
        {
            double r, per_cir;
            var PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.Read();
        }
    }
}