#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise005.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class newClass5
    {
        public int n;
    }

    public struct newStruct5
    {
        public int n;
    }

    public class Exercise005
    {
        public static void trackStruct(newStruct5 st)
        {
            st.n = 8;
        }

        public static void tracClass(newClass5 cl)
        {
            cl.n = 8;
        }

        public static void Main()
        {
            Console.Write("\n\nWhen a struct and a class instance is passed to a method :\n");
            Console.Write("--------------------------------------------------------------\n");
            var ns = new newStruct5();
            var nc = new newClass5();
            ns.n = 5;
            nc.n = 5;
            //value of the struct field did not changed by passing its instance		
            //because a copy of the struct was passed to the trackStruct method		
            trackStruct(ns);
            //value of the class field changed by passing its instance
            //because a reference to the class was passed to the tracClass method		
            tracClass(nc);
            Console.WriteLine("\nns.n = {0}", ns.n);
            Console.WriteLine("nc.n = {0}\n", nc.n);
        }
    }
}