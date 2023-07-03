using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9pros
{
    class Program

    {
        public class prostaklasa
        {
            private int numer;
            private string powitanie;

            public int Numer
            {
                get { return numer; }
                set { numer = value; }
            }
            public string Powitanie
            {
                get { return powitanie; }
                set { powitanie = value; }
            }

         
        }
        public static void sumuj(int[] tablica)
        {
            int wynik=0;
            for(int i = 0; i < 9; i++)
            {
                wynik += tablica[i];
            }
            Console.WriteLine(wynik);
        }
        public static prostaklasa[] kopia(prostaklasa[] tabela)
        {
            return tabela;
        }
            static void Main(string[] args)
        {
            
            int[] tabi =  {25, 2462, 24, 987, 8767, 658, 16, 8, 20, 74 };
            prostaklasa klasyk = new prostaklasa();
            prostaklasa klasycznie = new prostaklasa();
            prostaklasa klaskanie = new prostaklasa();
            prostaklasa klasowanie = new prostaklasa();
            prostaklasa klasowo = new prostaklasa();
            prostaklasa[] tabklas =  { klasyk, klasycznie, klaskanie, klasowanie, klasowo };
            prostaklasa[] kopiazapasowa;
            string tekst = "HALO";
            string tekstowa = "Na razie";
            string dlugitxt = "Przechowywanie zmiennych danego typu nie jest najlepszym rozwiązaniem w tym przypadku.";
            for(int i=0; i < 10; i++)
            {
                Console.Write(tabi[i]+" ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(tabklas[i].Numer + " " + tabklas[i].Powitanie);
            }
            Console.WriteLine("\n");
            for (int i=0; i<5; i++)
            {
                tabklas[i].Numer = i + 1;
                Console.WriteLine("Podaj powitanie: ");
                tabklas[i].Powitanie = Console.ReadLine();
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(tabklas[i].Numer + " " + tabklas[i].Powitanie);
            }
            Console.WriteLine("\n");
            sumuj(tabi);
            Console.WriteLine("\n");
            kopiazapasowa = kopia(tabklas);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(kopiazapasowa[i].Numer + " " + kopiazapasowa[i].Powitanie);
            }
            Console.WriteLine("\n");
            Console.WriteLine(tekst);
            Console.WriteLine(tekstowa);
            string nowytekst = tekst + tekstowa;
            nowytekst=nowytekst.Remove(3, 4);
            Console.WriteLine(nowytekst+"\n");
            StringBuilder stringujemy = new StringBuilder(dlugitxt);
            Console.WriteLine(stringujemy);
            stringujemy.Append(" Jednakże...");
            Console.WriteLine(stringujemy);
            stringujemy.Insert(25, "globalnych ");
            Console.WriteLine(stringujemy);
            stringujemy.Remove(36, 12);
            Console.WriteLine(stringujemy);
            stringujemy.Replace('a', 'A');
            Console.WriteLine(stringujemy);
            Console.ReadLine();
        }
    }
}
