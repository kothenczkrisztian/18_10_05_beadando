using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kothencz_krisztian_18_10_05_beadndo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg hány darab számot szeretne bekérni :  ");
            int tombMeret = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adjon meg {0} db számot :", tombMeret);
            int[] szamok = new int[tombMeret];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write((i + 1) + ". ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("A {0} bekért szám :", tombMeret);

            foreach (var item in szamok)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                int akt_ertek = szamok[i];
                if (akt_ertek > max)
                {
                    max = akt_ertek;
                }
            }
            Console.WriteLine("A legnagyobb szám : " + max);

            int min = 0;
            int minIndex;
            for (int i = 0; i < szamok.Length; i++)
            {
                min = szamok[i];
                minIndex = i;
                for (int j = 0; j < szamok.Length; j++)
                {
                    if (szamok[j] < min)
                    {
                        min = szamok[j];
                        minIndex = j;
                    }
                }
                szamok[minIndex] = szamok[i];
                szamok[i] = min;
            }
            Console.WriteLine("A legkisebb szám :  " + min);
            Console.ReadKey();
        }
    }
}
