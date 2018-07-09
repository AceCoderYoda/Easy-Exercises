#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    06. Answers.Exercise010.cs
// Created On    ::    09/07/2018 09:54
// Altered On    ::    09/07/2018 09:54
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise010
    {
        public static void Main()
        {
            int p, c, m;

            Console.Write("\n\n");
            Console.Write("Find eligibility for admission :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Eligibility Criteria :\n");
            Console.Write("Marks in Maths >=65\n");
            Console.Write("and Marks in Phy >=55\n");
            Console.Write("and Marks in Chem>=50\n");
            Console.Write("and Total in all three subject >=180\n");
            Console.Write("or Total in Maths and Physics >=140\n");
            Console.Write("-------------------------------------\n");


            Console.Write("Input the marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
            Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if (m + p + c >= 180 || m + p >= 140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");
        }
    }
}