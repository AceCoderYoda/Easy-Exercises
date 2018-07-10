#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise035.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections;

#endregion

namespace Easy_Exercises
{
    public class Exercise035
    {
        public static void Main()
        {
            const int WORD_SIZE = 4;

            // Define some 4-letter words to be scrambled.
            string[] words = {"abcd", "efgh", "ijkl", "mnop"};
            // Define two arrays equal to the number of letters in each word.
            var keys = new double[WORD_SIZE];
            var letters = new string[WORD_SIZE];
            // Initialize the random number generator.
            var rnd = new Random();

            // Scramble each word.
            foreach (var word in words)
            {
                for (var ctr = 0; ctr < word.Length; ctr++)
                {
                    // Populate the array of keys with random numbers.
                    keys[ctr] = rnd.NextDouble();
                    // Assign a letter to the array of letters.
                    letters[ctr] = word[ctr].ToString();
                }

                // Sort the array. 
                Array.Sort(keys, letters, 0, WORD_SIZE, Comparer.Default);
                // Display the scrambled word.
                var scrambledWord = string.Concat(letters[0], letters[1],
                    letters[2], letters[3]);
                Console.WriteLine("{0} --> {1}", word, scrambledWord);
            }
        }
    }
}