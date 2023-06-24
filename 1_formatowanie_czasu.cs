using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_formatowanie_czasu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sekundy;

            Console.WriteLine("Podaj liczbę sekund:");
            while (!int.TryParse(Console.ReadLine(), out sekundy) || sekundy < 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę sekund:");
            }

            string sformatowanyCzas = FormatujCzas(sekundy);

            Console.WriteLine("Sformatowany czas: " + sformatowanyCzas);
        }

        static string FormatujCzas(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy % 3600) / 60;
            int pozostaleSekundy = sekundy % 60;
            string sformatowaneGodziny, sformatowaneMinuty, sformatowaneSekundy;

            if (godziny < 10)
            {
                sformatowaneGodziny = "0" + godziny;
            }
            else
            {
                sformatowaneGodziny = godziny.ToString();
            }

            if (minuty < 10)
            {
                sformatowaneMinuty = "0" + minuty;
            }
            else
            {
                sformatowaneMinuty = minuty.ToString();
            }

            if (pozostaleSekundy < 10)
            {
                sformatowaneSekundy = "0" + pozostaleSekundy;
            }
            else
            {
                sformatowaneSekundy = pozostaleSekundy.ToString();
            }


            return $"{sformatowaneGodziny}:{sformatowaneMinuty}:{sformatowaneSekundy}";
        }
    }
}
