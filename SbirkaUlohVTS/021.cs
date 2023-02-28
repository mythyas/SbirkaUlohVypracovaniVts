using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    /*Napište program, který pro zadanou sumu peněz (1–200 Kč) vytiskne výčetku českých
    * kovových platidel potřebných k vyplacení zadané sumy.
    */
    class Program
    {
        static void Bankomat(int pocetPenez)
        {
            int[] bankovky = { 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] pocetBankovek = new int[bankovky.Length];
            for (int i = 6; i < bankovky.Length; i++)
            {

                while(pocetPenez - bankovky[i] >= 0)
                {
                    pocetPenez -= bankovky[i];
                    pocetBankovek[i]++;
                }
                if (pocetBankovek[i] > 0)
                {
                    Console.WriteLine("Obdržel jsi {0} {1} korun", pocetBankovek[i], bankovky[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ty: Mami můžu dostat peníze na svačinu.");
            Console.WriteLine("Mamka: Jasně! Kolik to stojí? Ale víc jak 200 ti nedám.");
            Console.Write("Ty: ");
            byte penizeNaSvacinu;
            while (!byte.TryParse(Console.ReadLine(), out penizeNaSvacinu))
            {
                Console.WriteLine("Hej dej mi nějakou normální cenu.");
            }
            if (penizeNaSvacinu>200||penizeNaSvacinu<1)
            {
                Console.WriteLine("Ha Ha Ha\nNic nedostaneš!");
                Console.ReadLine();
                return;
            }
            Bankomat(penizeNaSvacinu);
            Console.ReadLine();
        }
    }
}
