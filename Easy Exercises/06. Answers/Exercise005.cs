#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise005.cs
// Created On    ::    09/07/2018 09:49
// Altered On    ::    09/07/2018 09:50
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
            int vote_age;
            Console.Write("\n\n");
            Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            }
            else
            {
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
            }
        }
    }
}