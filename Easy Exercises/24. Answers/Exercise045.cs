using System;

namespace Easy_Exercises
{

public class Exercise045
{
    static void Main()
    {
        Console.Write("\n\n Compute what day will be Tomorrow :\n");
        Console.Write("----------------------------------------\n");
        Console.WriteLine(" Today is : {0}", DateTime.Today.ToString("dd/MM/yyyy"));
        DateTime dt = GetTomorrow();
        Console.WriteLine(" The Tomorrow will be : {0} \n", dt.ToString("dd/MM/yyyy"));
    }
    static DateTime GetTomorrow()
    {
        return DateTime.Today.AddDays(1);
    }
    }
}
