#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise055.cs
// Created On    ::    09/07/2018 09:05
// Altered On    ::    09/07/2018 09:05
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise055
    {
        public static int ArrayAdjacentElementsProduct(int[] input_array)
        {
            var arrayIndex = 0;
            var product = input_array[arrayIndex] * input_array[arrayIndex + 1];

            arrayIndex++;
            while (arrayIndex + 1 < input_array.Length)
            {
                product = input_array[arrayIndex] * input_array[arrayIndex + 1] > product
                    ? input_array[arrayIndex] * input_array[arrayIndex + 1]
                    : product;
                arrayIndex++;
            }

            return product;
        }

        public static void Main()
        {
            Console.WriteLine(ArrayAdjacentElementsProduct(new[] {2, 4, 2, 6, 9, 3}) == 27);
            Console.WriteLine(ArrayAdjacentElementsProduct(new[] {0, -1, -1, -2}) == 2);
            Console.WriteLine(ArrayAdjacentElementsProduct(new[] {6, 1, 12, 3, 1, 4}) == 36);
            Console.WriteLine(ArrayAdjacentElementsProduct(new[] {1, 4, 3, 0}) == 16);
        }
    }
}

}