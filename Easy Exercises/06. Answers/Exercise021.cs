#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise021.cs
// Created On    ::    09/07/2018 10:16
// Altered On    ::    09/07/2018 10:17
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise021
    {
        public static void Main()
        {
            int monno;


            Console.Write("\n\n");
            Console.Write("Read month number and display month name:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input Month No : ");
            monno = Convert.ToInt32(Console.ReadLine());

            switch (monno)
            {
                case 1:
                    Console.Write("January\n");
                    break;
                case 2:
                    Console.Write("February\n");
                    break;
                case 3:
                    Console.Write("March\n");
                    break;
                case 4:
                    Console.Write("April\n");
                    break;
                case 5:
                    Console.Write("May\n");
                    break;
                case 6:
                    Console.Write("June\n");
                    break;
                case 7:
                    Console.Write("July\n");
                    break;
                case 8:
                    Console.Write("August\n");
                    break;
                case 9:
                    Console.Write("September\n");
                    break;
                case 10:
                    Console.Write("October\n");
                    break;
                case 11:
                    Console.Write("November\n");
                    break;
                case 12:
                    Console.Write("December\n");
                    break;
                default:
                    Console.Write("invalid Month number. \nPlease try again ....\n");
                    break;
            }
        }
    }
}