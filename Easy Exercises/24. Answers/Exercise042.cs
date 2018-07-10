using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise042
    {
        public static void Main()
        {
            string dateString;
            CultureInfo culture;
            DateTimeStyles styles;
            DateTime dateResult;

            // Parse a date and time with no styles.
            dateString = "05/06/2016 10:00 AM";
            culture = CultureInfo.CreateSpecificCulture("de-DE");
            styles = DateTimeStyles.None;
            if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                Console.WriteLine("{0} converted to {1} {2}.",
                                  dateString, dateResult, dateResult.Kind);
            else
                Console.WriteLine("Unable to convert {0} to a date and time.",
                                  dateString);

            // Parse the same date and time with the AssumeLocal style.
            styles = DateTimeStyles.AssumeLocal;
            if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                Console.WriteLine("{0} converted to {1} {2}.",
                                  dateString, dateResult, dateResult.Kind);
            else
                Console.WriteLine("Unable to convert {0} to a date and time.", dateString);

            // Parse a date and time that is assumed to be local.
            // This time is five hours behind UTC. The local system's time zone is 
            // eight hours behind UTC.
            dateString = "2016/05/06T10:00:00-5:00";
            styles = DateTimeStyles.AssumeLocal;
            if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                Console.WriteLine("{0} converted to {1} {2}.",
                                  dateString, dateResult, dateResult.Kind);
            else
                Console.WriteLine("Unable to convert {0} to a date and time.", dateString);

            // Attempt to convert a string in improper ISO 8601 format.
            dateString = "05/06/2016T10:00:00-5:00";
            if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                Console.WriteLine("{0} converted to {1} {2}.",
                                  dateString, dateResult, dateResult.Kind);
            else
                Console.WriteLine("Unable to convert {0} to a date and time.", dateString);

            // Assume a date and time string formatted for the fr-BE culture is the local 
            // time and convert it to UTC.
            dateString = "2015-05-06 10:00";
            culture = CultureInfo.CreateSpecificCulture("fr-BE");
            styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal;
            if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                Console.WriteLine("{0} converted to {1} {2}.",
                                  dateString, dateResult, dateResult.Kind);
            else
                Console.WriteLine("Unable to convert {0} to a date and time.", dateString);

        }
    }
}
