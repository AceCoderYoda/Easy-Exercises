#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise009.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    internal struct book
    {
        public string title;
        public string author;
    }

    public class Exercise009
    {
        public static void Main()
        {
            var nobook = 1000;
            var books = new book[nobook];
            int i, j, n = 1, k = 1;
            Console.Write("\n\nInsert the information of two books :\n");
            Console.Write("-----------------------------------------\n");
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book {0} :", k);

                Console.Write("Input name of the book : ");
                books[j].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }
        }
    }
}