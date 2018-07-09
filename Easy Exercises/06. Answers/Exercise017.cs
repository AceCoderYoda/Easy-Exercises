#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise017.cs
// Created On    ::    09/07/2018 10:10
// Altered On    ::    09/07/2018 10:14
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise017
    {
        public static void Main()
        {
            int plamt;

            Console.Write("\n\n");
            Console.Write("Calculate profit and loss:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");


            Console.Write("Input Cost Price: ");
            var costPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            var sellPrice = Convert.ToInt32(Console.ReadLine());

            if (sellPrice > costPrice)
            {
                plamt = sellPrice - costPrice;
                Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
            }
            else if (costPrice > sellPrice)
            {
                plamt = costPrice - sellPrice;
                Console.Write("\nYou got a loss of amount : {0}\n", plamt);
            }
            else
            {
                Console.Write("\nYou are running in no profit no loss condition.\n");
            }
        }
    }
}