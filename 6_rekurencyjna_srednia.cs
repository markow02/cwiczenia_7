using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_rekurencyjna_srednia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tablica = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            int rozmiar = tablica.Length;

            double srednia = RekurencyjnaSrednia(tablica, rozmiar);

            Console.WriteLine("Średnia arytmetyczna: " + srednia);
        }

        static double RekurencyjnaSrednia(double[] tablica, int rozmiar)
        {
            if (rozmiar == 1)
            {
                return tablica[0];
            }
            else
            {
                // 1. Wywołujemy funkcję rekurencyjnie dla mniejszej tablicy (o jeden element mniej), co zwraca nam średnią dla n-1 liczb.
                // 2. Mnożymy wynik z poprzedniego kroku przez n-1, aby uzyskać sumę tych liczb.
                // 3. Dodajemy do wyniku ostatni element tablicy, aby uzyskać sumę n liczb.
                // 4. Dzielimy całość przez rozmiar tablicy, aby uzyskać średnią dla n liczb.
                return ((RekurencyjnaSrednia(tablica, rozmiar - 1) * (rozmiar - 1)) + tablica[rozmiar - 1]) / rozmiar;
            }

        }
    }
}
