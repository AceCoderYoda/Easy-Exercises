#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise023.cs
// Created On    ::    09/07/2018 10:31
// Altered On    ::    09/07/2018 10:31
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise023
    {
        private static void Main(string[] args)
        {
            int monno;

            Console.Write("\n\n");
            Console.Write("Read month number and display number of days for that month:\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Month No : ");
            monno = Convert.ToInt32(Console.ReadLine());
            switch (monno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Month  have 31 days. \n");
                    break;
                case 2:
                    Console.Write("The 2nd month is a February and have 28 days. \n");
                    Console.Write("in leap year The February month  Have 29 days.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Month have 30 days. \n");
                    break;
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }
        }
    }
}