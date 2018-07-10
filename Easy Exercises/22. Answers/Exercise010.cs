#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise010.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public struct sampStru
    {
        public double Value { get; set; }

        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }

    public struct Square
    {
        private sampStru ht;

        public sampStru Length { get; set; }

        public sampStru Breadth
        {
            get => ht;
            set => ht = value;
        }

        public void newSquare()
        {
            var rct = new sampStru();

            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            Length = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }

        public sampStru sqrLength()
        {
            var rct = new sampStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }

    public class Exercise010
    {
        private static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            var Sqre = new Square();
            Sqre.newSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}