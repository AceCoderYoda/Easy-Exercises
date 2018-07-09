#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    12. Answers.Exercise008.cs
// Created On    ::    09/07/2018 14:02
// Altered On    ::    09/07/2018 14:03
// By            ::    Arjan Crielaard

#endregion

using System;
using System.Collections.Generic;

namespace Easy_Exercises
{
    public class Exercise008
    {
        static void Main(string[] args)
        {
            List<Caracter> listChar = new List<Caracter> {new Caracter('A'), new Caracter('B'), new Caracter('C')};

            Console.WriteLine("Combinations of A, B and C are");

            List<string> permutation = Permutate(listChar, listChar.Count);

            foreach (string p in permutation)
                Console.WriteLine(p);

        }

        public static List<string> Permutate(List<Caracter> elem, int n)
        {
            List<string> permutation = new List<string>();

            Queue<Data> a1 = new Queue<Data>();
            List<Caracter> vacia = new List<Caracter>();
            a1.Enqueue(new Data(vacia, n));

            while (a1.Count > 0)
            {
                Data d = a1.Dequeue();
                if (d.n == 0)
                {
                    string pActual = Concatenar(d.actual);
                    if (!permutation.Contains(pActual))
                    {
                        permutation.Add(pActual);
                    }
                }
                else
                {
                    for (int i = 0; i < elem.Count; i++)
                    {
                        if (!d.actual.Contains(elem[i]))
                        {
                            List<Caracter> lis = new List<Caracter>();
                            for (int k = 0; k < d.actual.Count; k++)
                            {
                                lis.Add(d.actual[k]);
                            }
                            lis.Add(elem[i]);
                            Data d1 = new Data(lis, d.n - 1);

                            a1.Enqueue(d1);
                        }
                    }
                }
            }

            return permutation;
        }

        static string Concatenar(List<Caracter> listaCaracteres)
        {
            string cadena = "";
            for (int i = 0; i < listaCaracteres.Count; i++)
            {
                cadena += listaCaracteres[i].caracter;
            }
            return cadena;
        }
    }

    internal class Data
    {
        public List<Caracter> actual;
        public int n;

        public Data(List<Caracter> actual, int n)
        {
            this.actual = actual;
            this.n = n;
        }
    }

    internal class Caracter
    {
        public char caracter;
        public Caracter(char caracter)
        {
            this.caracter = caracter;
        }
    }
}
}