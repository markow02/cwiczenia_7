using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_mediana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 5, 2, 8, 4, 1, 9, 3, 7, 6 };
            int rozmiar = liczby.Length;

            double mediana = ObliczMediane(liczby, rozmiar);
            Console.WriteLine("Mediana: " + mediana);
        }

        static double ObliczMediane(int[] tablica, int rozmiar)
        {
            int[] kopiaTablicy = new int[rozmiar];
            Array.Copy(tablica, kopiaTablicy, rozmiar);

            Array.Sort(kopiaTablicy); // Sortujemy kopię tablicy


            if (rozmiar % 2 == 0)
            {
                // Jeśli rozmiar tablicy jest parzysty
                // Obliczamy indeksy dwóch środkowych elementów
                int indeks1 = rozmiar / 2 - 1;
                int indeks2 = rozmiar / 2;
                return (kopiaTablicy[indeks1] + kopiaTablicy[indeks2]) / 2.0;
            }
            else
            {
                // Jeśli rozmiar tablicy jest nieparzysty
                // Obliczamy indeks elementu znajdującego się dokładnie w środku tablicy
                int indeks = rozmiar / 2;
                return kopiaTablicy[indeks];
            }
        }
    }
}
