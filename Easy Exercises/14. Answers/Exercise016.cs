#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise016.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise016
    {
        public static void Main()
        {
            string username, password;
            var ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;
            } while ((username != "abcd" || password != "1234") && ctr != 3);

            if (ctr == 3)
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }
    }
}