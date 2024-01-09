using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A.4.feladat: A mm-ben megadott értéket bontsunk méterre, deciméterre, centiméterre!

namespace gyfek_003_004
{
    class Program
    {
        static void Main()
        {
            int ertek = int.Parse(Console.ReadLine());
            MegysegAtvalto(ertek);
            Console.ReadLine();
        }

        static void MegysegAtvalto(double szam)
        {
            Console.WriteLine($"{szam} mm = {(double) (szam/1000):0.00} m");
            Console.WriteLine($"{szam} mm = {(double) (szam/100):0.00} dm");
            Console.WriteLine($"{szam} mm = {(double) (szam/10):0.00} cm");
        }
    }
}
