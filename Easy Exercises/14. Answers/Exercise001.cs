#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise001.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise001
    {
        public static void Main()
        {
            string str;

            Console.Write("\n\nAccept a string from keyboard :\n");
            Console.Write("-----------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The string you entered is : {0}\n", str);
        }
    }
}