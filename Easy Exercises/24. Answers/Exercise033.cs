using System;
using System.Globalization;
using System.Threading;

namespace Easy_Exercises
{

public class Exercise033
{
    public static void Main()
    {
        // Create an array of culture names.
        String[] names = { "en-CA", "en-AU", "fr-CH", "de-AT" };
        // Initialize a DateTime object.
        DateTime dateValue = new System.DateTime(2016, 8, 17, 10, 30, 15);

        // Iterate the array of culture names.
        foreach (var name in names)
        {
            // Change the culture of the current thread.
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(name);
            // Display the name of the current culture and the date.
            Console.WriteLine("Current culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Date: {0:G}", dateValue);

            // Display the long time pattern and the long time.
            Console.WriteLine("Long time pattern: '{0}'",
                DateTimeFormatInfo.CurrentInfo.LongTimePattern);
            Console.WriteLine("Long time with format string:     {0:T}", dateValue);
            Console.WriteLine("Long time with ToLongTimeString:  {0}\n",
                dateValue.ToLongTimeString());
        }
    }
    }
}
