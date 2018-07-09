#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise003.cs
// Created On    ::    09/07/2018 09:32
// Altered On    ::    09/07/2018 09:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise003
    {
        public static void Main()
        {
            string username, password;
            int ctr = 0, dd = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Defaule username and password is : username and password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    dd = 1;
                    ctr = 3;
                }

                else
                {
                    dd = 0;
                    ctr++;
                }
            } while ((username != "username" || password != "password")
                     && ctr != 3);

            if (dd == 0)
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            else if (dd == 1) Console.Write("\nPassword entered successfull!\n\n");
        }
    }
}