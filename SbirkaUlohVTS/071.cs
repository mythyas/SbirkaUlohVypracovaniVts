using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    class Program
    {
        /*Sestavte algoritmus, kterým po zadání tří hodnot a, b, c zjistíte, zda existuje trojúhelník
        s délkami stran a, b, c a pokud existuje, je-li pravoúhlý.Při sestavování algoritmu dbejte
        zásad strukturovaného programování. Algoritmus zapište pomocí vývojového diagramu*/
        static void Main(string[] args)
        {
            //blok, který uloží hodnoty a, b, c
            int[] hodnoty = new int[3];
            Console.WriteLine("Zadejte hodnoty a, b, c: ");
            char a = 'a';
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}: ", (char)(a + i));
                int[i] = int.Parse(Console.ReadLine());
            }
            //pole s a, b, c


            //blok, který předělá pole tak, aby nejvyšší prvek byl na indexu 0
            for (int i = 1; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] > hodnoty[0])
                {
                    int pom;
                    pom = hodnoty[0];
                    hodnoty[0] = hodnoty[i];
                    hodnoty[i] = pom;
                }
            }


        }
    }
}
