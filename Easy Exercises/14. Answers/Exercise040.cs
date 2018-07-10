#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise040.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise040
    {
        public static void Main()
        {
            // Embed an array of characters in a string
            var strSource = "Python";
            char[] destination =
            {
                'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e', ' ', 'C',
                'S', 'h', 'a', 'r', 'p', ' ', 'T', 'u', 't', 'o', 'r', 'i', 'a', 'l'
            };

            // Print the char array
            Console.WriteLine(destination);

            // Embed the source string in the destination string
            strSource.CopyTo(0, destination, 11, strSource.Length);

            // Print the resulting array
            Console.WriteLine(destination);

            strSource = "A different string";

            // Embed only a section of the source string in the destination
            strSource.CopyTo(2, destination, 10, 9);

            // Print the resulting array
            Console.WriteLine(destination);
        }
    }
}