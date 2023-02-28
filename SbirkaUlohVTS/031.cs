using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    /*Napište program, který načítá na vstupu velká písmena a tiskne malá písmena, dokud
    nebude stisknuto malé nebo velké q
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pište písmena dokud nenapíšete q tak budu ukládat.");
            string vystup = "";
            char znak;
            while ((znak = Console.ReadKey().KeyChar).ToString().ToLower() != "q")
            {
                if (znak >= 65 && znak <= 90)
                {
                    vystup += znak;
                }
            }
            Console.WriteLine();
            Console.WriteLine(vystup.ToLower());
            Console.ReadLine();
        }
    }
}
