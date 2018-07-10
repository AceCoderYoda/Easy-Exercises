using System;

namespace Easy_Exercises
{

public class Exercise027
{
    public static void Main()
    {
        object[] values = { (int) 24, (long) 10653, (byte) 24, (sbyte) -5,
            26.3, "string" };
        foreach (var value in values)
        {
            Type t = value.GetType();
            if (t.Equals(typeof(byte)))
                Console.WriteLine("{0} is an unsigned byte.", value);
            else if (t.Equals(typeof(sbyte)))
                Console.WriteLine("{0} is a signed byte.", value);
            else if (t.Equals(typeof(int)))
                Console.WriteLine("{0} is a 32-bit integer.", value);
            else if (t.Equals(typeof(long)))
                Console.WriteLine("{0} is a 32-bit integer.", value);
            else if (t.Equals(typeof(double)))
                Console.WriteLine("{0} is a double-precision floating point.",
                    value);
            else
                Console.WriteLine("'{0}' is another data type.", value);
        }
    }
    }
}
