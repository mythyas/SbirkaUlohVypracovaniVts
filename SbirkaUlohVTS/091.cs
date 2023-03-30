using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    class Program
    {
        /*Na vstupu je dána posloupnost celých čísel zakončená číslem nula. Vytiskněte největší číslo a
        kolikrát se v posloupnosti vyskytuje.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte posloupnost celých čísel.\nPro ukončení zadávání stiskněte 0.");
            List<int> cisla = new List<int>();
            int pom;
            while (true)
            {
                pom = int.Parse(Console.ReadLine());
                if (pom == 0)
                {
                    break;
                }
                cisla.Add(pom);
            }

        }
    }
}
