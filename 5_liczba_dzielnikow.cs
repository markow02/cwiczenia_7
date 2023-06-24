using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_liczba_dzielnikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną większą od 5:");
            int liczba = int.Parse(Console.ReadLine());

            int liczbaDzielnikow = LiczbaDzielnikowPierwszych(liczba);

            Console.WriteLine("Liczba dzielników pierwszych: " + liczbaDzielnikow);
        }

        // Funkcja obliczająca liczbę dzielników pierwszych danej liczby n
        static int LiczbaDzielnikowPierwszych(int n)
        {
            if (n <= 5)
            {
                return 0;
            }

            int liczbaDzielnikow = 0;

            // Iterujemy od 2 do pierwiastka kwadratowego z n,
            // ponieważ największy możliwy dzielnik pierwszy liczby n może wynosić co najwyżej jej pierwiastek kwadratowy.
            // Iterując tylko do tego zakresu, zmniejszamy liczbę iteracji i poprawiamy wydajność.
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Sprawdzamy, czy n jest podzielne przez dany dzielnik i czy dzielnik jest liczbą pierwszą
                if (n % i == 0 && CzyPierwsza(i))
                {
                    liczbaDzielnikow++; 
                }
            }

            return liczbaDzielnikow; 
        }

        // Funkcja sprawdzająca, czy dana liczba n jest liczbą pierwszą
        static bool CzyPierwsza(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Jeśli n jest podzielne przez dany dzielnik, to nie jest liczbą pierwszą
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
