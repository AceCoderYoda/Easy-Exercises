#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise006.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    internal struct newStruct6
    {
        private int num;

        public int n
        {
            get => num;
            set
            {
                if (value < 50)
                    num = value;
            }
        }

        public void clsMethod()
        {
            Console.WriteLine("\nThe stored value is: {0}\n", num);
        }
    }

    public class Exercise006
    {
        public static void Main()
        {
            Console.Write("\n\nDeclares a struct with a property, a method, and a private field :\n");
            Console.Write("----------------------------------------------------------------------\n");
            var myInstance = new newStruct6();
            myInstance.n = 15;
            myInstance.clsMethod();
        }
    }
}