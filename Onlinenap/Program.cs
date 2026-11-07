using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlinenap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] elsofeladat = { 5, 10, 15, 20 };
            Console.WriteLine(elsofeladat[1]);
            Console.WriteLine(elsofeladat[3]);
            Console.WriteLine(elsofeladat.Length); */

            /*
            int[] szamok = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Add meg a {i + 1}. számot: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(string.Join(", ", szamok));*/

            /*
            int[] szamok = { 1, 4, 6 };
            for (int i = szamok.Length - 1; i >= 0; i--)
            {
                Console.Write(szamok[i] + (i > 0 ? ", " : ""));
            }
            Console.WriteLine();*/

            /*
            int[] szamok = { 0, 1, 2, 5, -4 };
            foreach (int szam in szamok)
            {
                string parossag = (szam % 2 == 0) ? "páros" : "páratlan";
                Console.WriteLine($"{szam}: {parossag}");
            }*/

            /*
            int[] szamok = { 1, -2, 3 };
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] *= 10;
            }

            Console.WriteLine(string.Join(", ", szamok));*/

            /*
            int[] szamok = { -3, 0, 2, 8 };
            int darab = 0;
            foreach (int szam in szamok)
            {
                if (szam > 0)
                {
                    darab++;
                }
            }

            Console.WriteLine($"{darab} darab pozitív szám van.");*/


            /*
            int[] szamok = { 1, 2, 6 };
            if (szamok.Length == 0)
            {
                Console.WriteLine("A tömb üres");
            }
            else
            {
                int osszeg = 0;
                foreach (int szam in szamok)
                {
                    osszeg += szam;
                }
                double atlag = (double)osszeg / szamok.Length;

                Console.WriteLine($"Összeg: {osszeg}, Átlag: {atlag}");
            }*/


            /*
            int[] szamok = { -7, -2, -9 };

            if (szamok.Length == 0)
            {
                Console.WriteLine("A tömb üres, nincsenek elemek.");
            }
            else
            {
                int min = szamok[0];
                int max = szamok[0];
                foreach (int szam in szamok)
                {
                    if (szam < min) min = szam;
                    if (szam > max) max = szam;
                }
                Console.WriteLine($"Min.: {min}, Max.: {max}");
            }*/

            int[] szamok = { 5, 9, 2, 4, 8 };

            for (int i = 0; i < szamok.Length; i += 2)
            {
                Console.Write(szamok[i] + (i < szamok.Length - 2 ? ", " : ""));
            }
            Console.WriteLine();





        }
    }
}
