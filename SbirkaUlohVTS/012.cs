using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string adresa = @"U:\temp\čísla.txt";
            FileStream fs = new FileStream(adresa, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] cisla = sr.ReadToEnd().Split(' ');
            foreach(string cislo in cisla)
            {
                uint hodnota;
                if (!uint.TryParse(cislo, out hodnota))
                    continue;
                if(JePrvocislo(hodnota))
                    Console.WriteLine(cislo);
            }
            Console.ReadLine();
        }
    }
}
