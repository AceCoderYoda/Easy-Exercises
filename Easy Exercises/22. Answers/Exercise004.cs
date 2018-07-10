#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise004.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    internal class aNewClass
    {
        public int x;
        public int y;
    }

    //create a structure 
    internal struct aNewStruc
    {
        public int x;
        public int y;
    }

    public class Exercise004
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nCreate a structure and Assign the Value and call it :\n");
            Console.Write("---------------------------------------------------------\n");
            var ClassNum1 = new aNewClass();
            ClassNum1.x = 75;
            ClassNum1.y = 95;
            //	ClassNum2 is ClassNum1 type	
            var ClassNum2 = ClassNum1;
            ClassNum1.x = 7500;
            ClassNum1.y = 9500;
            Console.WriteLine("\nAssign in Class:       x:{0},   y:{1}", ClassNum2.x, ClassNum2.y);
            var StrucNum1 = new aNewStruc();
            StrucNum1.x = 750;
            StrucNum1.y = 950;
            //	StrucNum2 is StrucNum1 type			
            var StrucNum2 = StrucNum1;
            StrucNum1.x = 75;
            StrucNum1.y = 95;
            Console.WriteLine("Assign in Structure:   x:{0},    y:{1}\n\n", StrucNum2.x, StrucNum2.y);
        }
    }
}