#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise007.cs
// Created On    ::    09/07/2018 09:51
// Altered On    ::    09/07/2018 09:51
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise007
    {
        public static void Main()
        {
            float PerHeight;
            Console.Write("\n\n");
            Console.Write("Accept the height of a person in centimeter and categorize them:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the height of the person (in centimetres):");
            PerHeight = Convert.ToInt32(Console.ReadLine());

            if (PerHeight < 150.0)
                Console.Write("The person is Dwarf. \n\n");
            else if (PerHeight >= 150.0 && PerHeight <= 165.0)
                Console.Write("The person is  average heighted. \n\n");
            else if (PerHeight >= 165.0 && PerHeight <= 195.0)
                Console.Write("The person is taller. \n\n");
            else
                Console.Write("Abnormal height.\n\n");
        }
    }
}