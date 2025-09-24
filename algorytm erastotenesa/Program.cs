using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytm_erastotenesa
{
    internal class Program
    {
        private const int N = 100;
        static void Main(string[] args)
        {
            bool[] A = new bool[N + 1];
            for (int i = 2; i <= N; i++)
                A[i] = true;

            wypelnijTablice(A);

            Console.WriteLine("Liczby pierwsze:");
            for (int i = 2; i <= N; i++)
                if (A[i])
                    Console.Write($"{i}, ");

        }


        /*
         * Nazwa Funkcji: WypelnijTablice 
         * opis funkcji: funkcja wypełnia tablice liczbami pierwszymi
         * parametry: 1- bool[] A - tablica 
         * zwracany typ i opis: nic nie zwraca
         * autor: Miłosz Todys
         */


        private static void wypelnijTablice(bool[] A)
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (A[i])
                    for (int j = 2 * i; j <= N; j = j + i)
                        A[j] = false;
            }
        }

    }
}
