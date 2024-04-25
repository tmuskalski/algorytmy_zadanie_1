using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliczenia_06_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 64, 34, 25, 12, 22, 11, 90 };
            Printarray(tab);

            string wynik = SprawdzKolejnosc(tab);
            Console.WriteLine($"Czy liczby są ustawione w kolejności rosnącej przed sortowaniem? {wynik}");

            Console.WriteLine(" wolna przestrzeń ");
            BubbleSort(tab);
            Printarray(tab);
            string wynik2 = SprawdzKolejnosc(tab);
            Console.WriteLine($"Czy liczby są ustawione w kolejności rosnącej po sortowaniu? {wynik2}");

        }

        static string SprawdzKolejnosc(int[] tablica)
        {
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    return "NIE";
                }
            }
            return "TAK";
        }

        static void BubbleSort(int[] tablica)
        {
            int n = tablica.Length;
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = 0; i < n - k - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        // Zamiana miejscami
                        int temp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = temp;
                    }
                }
            }
        }


        private static void Printarray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
