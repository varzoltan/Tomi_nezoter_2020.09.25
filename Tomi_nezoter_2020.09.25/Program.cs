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

            //4.feladat
            int egy = 0;
            int ketto = 0;
            int harom = 0;
            int negy = 0;
            int ot = 0;
            for (int i = 0;i <n; i++)
            {
                for (int z = 0; z<20;z++)
                {
                    if (kategoria[i].Substring(z,1) == "1")
                    {
                        egy++;
                    }
                    if (kategoria[i].Substring(z, 1) == "2")
                    {
                        ketto++;
                    }
                    if (kategoria[i].Substring(z, 1) == "3")
                    {
                        harom++;
                    }
                    if (kategoria[i].Substring(z, 1) == "4")
                    {
                        negy++;
                    }
                    if (kategoria[i].Substring(z, 1) == "5")
                    {
                        ot++;
                    }
                }
            }
            /*int csere,pozicio = -1;
            int[] maxkat = {egy,ketto,harom,negy,ot};
            int[] sorba = new int[maxkat.Length];
            string[] hany = {1,2,3,4,5};
            Console.WriteLine();
            for (int i = 0; i < maxkat.Length; i++)
            {
                Console.Write($"{maxkat[i]} ");
            }
            for(int j = 0;j<hany.length;j++)
            {
                szamlal = 0;
                for (int i = 0;i<n;i++)
                {
                    for (int k=0;k<20;k++)
                    {
                        if (kategoria[i].Substring(k,1) == hany[j]) 
                        {
                            szamlal++;
                        }
                    }
                }
                hany[j] = szamlal.ToString();
            }
            Console.WriteLine();
            for (int i=0;i<maxkat.Length;i++)
            {
                Console.Write($"{maxkat[i]} {sorba[i]},");
            }*/
            int max = egy;
            if (max<ketto)
            {
                max = ketto;
            }
            if (max<harom)
            {
                max = harom;
            }
            if (max<negy)
            {
                max = negy;
            }
            if (max<ot)
            {
                max = ot;
            }
            if (max== egy)
            {
                Console.WriteLine("A legtöbb jegyet a(z) 1. árkategóriában értékesítették.");
            }
            if (max == ketto)
            {
                Console.WriteLine("A legtöbb jegyet a(z) 2. árkategóriában értékesítették.");
            }
            if (max == harom)
            {
                Console.WriteLine("A legtöbb jegyet a(z) 3. árkategóriában értékesítették.");
            }
            if (max == negy)
            {
                Console.WriteLine("A legtöbb jegyet a(z) 4. árkategóriában értékesítették.");
            }
            if (max == ot)
            {
                Console.WriteLine("A legtöbb jegyet a(z) 5. árkategóriában értékesítették.");
            }

            //5.feladat
            Console.WriteLine(egy*5000+ketto*4000+harom*3000+negy*2000+ot*1500);

            //6.feladat
            int egyedul = 0;
            for (int i = 0;i<n;i++)
            {
                if (foglaltsag[i].Substring(0, 2) == "ox")
                {
                    egyedul++;
                }
                if (foglaltsag[i].Substring(17, 2) == "xo")
                {
                    egyedul++;
                }
                for (int z =0;z<17;z++)
                {

                    if (foglaltsag[i].Substring(z,3) =="xox")
                    {
                        egyedul++;
                    }

                }
            }
            Console.WriteLine($"6.Feladat: {egyedul} egyedüli szék van.");

            //7.feladat
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\Downloads\szabad.txt");
            for (int i = 0;i<n;i++)
            {
                for (int j = 0;j<20;j++)
                {
                    
                    if (foglaltsag[i][j] == 'o')
                    {
                        ir.Write(kategoria[i][j]);
                    }
                    else
                    {
                        ir.Write("x");
                    }                  
                }
                ir.WriteLine();
            }
            ir.Close();
            Console.ReadKey();
        }
    }
}
