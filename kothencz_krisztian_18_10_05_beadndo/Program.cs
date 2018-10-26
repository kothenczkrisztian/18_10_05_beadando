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
            Console.WriteLine("Kérem ajon meg 10 számot:  ");
            int[] szamok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write((i + 1) + ". ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("A 10 bekért szám :");

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
            Console.ReadKey();
        }
    }
}
