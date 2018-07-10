using System;
using System.Globalization;
using System.Threading;

namespace Easy_Exercises
{

public class Exercise034
{
    public static void Main()
    {
        DateTime dateToDisplay = new DateTime(2016, 8, 17, 8, 42, 50);
        CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
        // Change culture to en-NZ.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-NZ");
        Console.WriteLine("Displaying short date for {0} culture:",
            Thread.CurrentThread.CurrentCulture.Name);
        Console.WriteLine("   {0} (Short Date String)",
            dateToDisplay.ToShortDateString());
        // Display using 'd' standard format specifier to illustrate it is
        // identical to the string returned by ToShortDateString.
        Console.WriteLine("   {0} ('d' standard format specifier)",
            dateToDisplay.ToString("d"));
        Console.WriteLine();

        // Change culture to fi-FI.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");
        Console.WriteLine("Displaying short date for {0} culture:",
            Thread.CurrentThread.CurrentCulture.Name);
        Console.WriteLine("   {0}", dateToDisplay.ToShortDateString());
        Console.WriteLine();

        // Change culture to de-CH.    
        Thread.CurrentThread.CurrentCulture = new CultureInfo("de-CH");
        Console.WriteLine("Displaying short date for {0} culture:",
            Thread.CurrentThread.CurrentCulture.Name);
        Console.WriteLine("   {0}", dateToDisplay.ToShortDateString());

        // Restore original culture.
        Thread.CurrentThread.CurrentCulture = originalCulture;
    }
    }
}
