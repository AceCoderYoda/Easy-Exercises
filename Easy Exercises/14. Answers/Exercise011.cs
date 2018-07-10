#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise011.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise011
    {
        public static void Main()
        {
            string str;
            char[] arr1;
            char ch;
            int i, j, l;
            Console.Write("\n\nSort a string array in ascending order :\n");
            Console.Write("--------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (i = 1; i < l; i++)
            for (j = 0; j < l - i; j++)

                if (arr1[j] > arr1[j + 1])
                {
                    ch = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = ch;
                }

            Console.Write("After sorting the string appears like : \n");
            foreach (var c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }

            Console.WriteLine("\n");
        }
    }
}