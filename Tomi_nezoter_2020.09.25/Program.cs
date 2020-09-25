using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tomi_nezoter_2020._09._25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foglaltsag = new string[15];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\foglaltsag.txt");
            int n = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                foglaltsag[n] = sor;
                n++;
            }
            olvas.Close();
            string[] kategoria = new string[15];
            StreamReader olvas1 = new StreamReader(@"C:\Users\Rendszergazda\Downloads\kategoria.txt");
            int m = 0;
            while (!olvas1.EndOfStream)
            {
                string sor = olvas1.ReadLine();
                kategoria[m] = sor;
                m++;
            }
            olvas1.Close();
            Console.WriteLine("1. feladat: beolvasás kész!");
            Console.Write("\n2.Felaadt:\nAdjon meg egy sor számot:");
            int sor1 = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg egy szék számot:");
            int szek = int.Parse(Console.ReadLine());
            //szek = szek - 1;
            if (foglaltsag[sor1].Substring(szek-2, 1) == "x")
            {
                Console.WriteLine("Ez a hely már foglalt.");
            }
            else
            {
                Console.WriteLine("Ez a hely még szabad.");
            }

            //3.feladat
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z<20;z++)
                {
                    if (foglaltsag[i].Substring(z, 1) == "x")
                    {
                        x++;
                    }
                }
            }
            Console.Write($"Az előadásra eddig {x} jegyet adtak el, ez a nézőtér {x/3}%-a.");
            Console.ReadKey();
        }
    }
}
