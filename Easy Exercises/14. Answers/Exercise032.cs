#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise032.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class TestClass
    {
    }

    public class Exercise032
    {
        public static void Main()
        {
            var test = new TestClass();
            object[] objectsToCompare =
            {
                test, test.ToString(), 123,
                123.ToString(), "some text",
                "Some Text"
            };
            var s = "some text";
            foreach (var objectToCompare in objectsToCompare)
                try
                {
                    var i = s.CompareTo(objectToCompare);
                    Console.WriteLine("Comparing '{0}' with '{1}': {2}",
                        s, objectToCompare, i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Bad argument: {0} (type {1})",
                        objectToCompare,
                        objectToCompare.GetType().Name);
                }
        }
    }
}