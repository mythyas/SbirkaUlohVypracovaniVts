using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    /*Napište metodu, která zjišťuje, zda je dané přirozené číslo prvočíslo. S pomocí této funkce
    napište program, který
    • čte na vstupu číslo a tiskne, zda je nebo není prvočíslo
    • čte ze souboru posloupnost přirozených čísel a vypisuje prvočísla.
    */
    class Program
    {
        static bool JePrvocislo(uint cislo)
        {
            if (cislo == 0 || cislo == 1)
                return false;
            if (cislo == 2)
                return true;
            for (int i = 2; i < Math.Pow(cislo, 1/2.0); i++)
            {
                if (cislo % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Napište kladné celé číslo a já zjistím, jestli se jedná o prvočíslo: ");
                uint moznePrvocislo;
                while (!uint.TryParse(Console.ReadLine(), out moznePrvocislo))
                {
                    Console.Write("Vámi zadané číslo není správného formátu.\nZkuste to prosím znovu: ");
                }
                if (JePrvocislo(moznePrvocislo))
                    Console.WriteLine("{0} je skutečně prvočíslo.", moznePrvocislo);
                else
                    Console.WriteLine("{0} není prvočíslo.",moznePrvocislo);
                Console.Write("Přejete si pokračovat? [a/n]: ");
            } while (Console.ReadLine().ToLower() == "a");
        }
    }
}
