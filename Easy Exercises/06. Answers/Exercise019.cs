#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise019.cs
// Created On    ::    09/07/2018 10:14
// Altered On    ::    09/07/2018 10:14
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise019
    {
        private static void Main(string[] args)
        {
            string notes;
            char grd;
            Console.Write("\n\n");
            Console.Write("Accept a grade and display equivalent description:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the grade :");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = " Excellent";
                    break;
                case 'V':
                    notes = " Very Good";
                    break;
                case 'G':
                    notes = " Good ";
                    break;
                case 'A':
                    notes = " Average";
                    break;
                case 'F':
                    notes = " Fails";
                    break;
                default:
                    notes = "Invalid Grade Found.";
                    break;
            }

            Console.Write("You have chosen  : {0}\n", notes);
        }
    }
}