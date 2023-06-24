using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dlugosc_odcinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 1.5; // x początkowe
            double y1 = 2.5; // y początkowe
            double x2 = 4.2; // x konćowe
            double y2 = 6.7; // y konćowe

            double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + dlugosc);
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1; 
            double deltaY = y2 - y1; 

            double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY); // twierdzenie Pitagorasa

            return dlugosc;
        }
    }
}
