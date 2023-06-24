using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zblizone_wiersze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = {
                { 1, 2, 3, 4 },
                { 1, 3, 2, 4 },
                { 4, 2, 3, 1 },
                { 3, 4, 1, 2 }
            };

            int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);

            Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", najblizszeWiersze[0], najblizszeWiersze[1]);
        }

        static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
        {
            int najmniejszaRoznica = int.MaxValue;
            int[] najblizszeWiersze = new int[2];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = i + 1; j < tablica.GetLength(0); j++)
                {
                    int roznica = ObliczRozniceWierszy(tablica, i, j);

                    if (roznica < najmniejszaRoznica)
                    {
                        najmniejszaRoznica = roznica;
                        najblizszeWiersze[0] = i;
                        najblizszeWiersze[1] = j;
                    }
                }
            }

            return najblizszeWiersze;
        }

        static int ObliczRozniceWierszy(int[,] tablica, int i, int j)
        {
            int roznica = 0;

            for (int k = 0; k < tablica.GetLength(1); k++)
            {
                int aik = tablica[i, k];
                int ajk = tablica[j, k];
                roznica += (aik - ajk) * (aik - ajk);
            }

            return roznica;
        }
    }
}
