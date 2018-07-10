#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise021.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise021
    {
        private static void Main(string[] args)
        {
            var listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write(
                "\nLINQ : Remove range of items from list by passing start index and number of elements to delete  : ");
            Console.Write(
                "\n------------------------------------------------------------------------------------------------\n");

            var _result1 = from y in listOfString
                select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1) Console.WriteLine("Char: {0} ", tchar);

            listOfString.RemoveRange(1, 3);

            var _result = from z in listOfString
                select z;
            Console.Write(
                "\nHere is the list after removing the three items starting from the item index 1 from the list : \n");
            foreach (var rChar in _result) Console.WriteLine("Char: {0} ", rChar);

            Console.ReadLine();
        }
    }
}