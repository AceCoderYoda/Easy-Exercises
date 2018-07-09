#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise011.cs
// Created On    ::    09/07/2018 09:41
// Altered On    ::    09/07/2018 09:41
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
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            var num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                var remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }

            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}

}