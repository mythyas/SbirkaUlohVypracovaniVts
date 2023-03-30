using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    /*Naprogramujte automat pro vydávání lístků na vlak, který určuje cenu podle následující
    tabulky
    vzdálenost v km         cena za km
    1-3                         15 Kč
    4-5                         13 Kč
    6-7                         11 Kč
    >8                          10 Kč
    Pro zadanou vzdálenost vytiskne odpovídající cenu jízdenky.
    */
    class Program
    {
        static int UrciSazbu(int pocetKilometru)
        {
            switch (pocetKilometru)
            {
                case 1:
                case 2:
                case 3:
                    return 15;
                case 4:
                case 5:
                    return 13;
                case 6:
                case 7:
                    return 11;
                default:
                    return 10;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Jak daleko chcete jet: ");
                int pocetKilometru = int.Parse(Console.ReadLine());
                if (pocetKilometru < 1)
                    return;
                int sazba = UrciSazbu(pocetKilometru);
                Console.WriteLine("Cena vaší jízdenky je {0} Kč", pocetKilometru * sazba);
            } while (true);
        }
    }
}
