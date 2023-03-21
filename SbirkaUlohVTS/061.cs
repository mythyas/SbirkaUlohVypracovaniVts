using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SbirkaUlohVTS
{
    /*Napište program, který zobrazuje v konzolovém okně vlastních rozměrů na náhodných
    místech různě barevné hvězdičky.
    */
    class Program
    {
        static Random random = new Random();
        static void RandomHvezda()
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(16);
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void RandomPozice()
        {
            Console.SetCursorPosition(random.Next(Console.WindowWidth), random.Next(Console.WindowHeight));
            Console.CursorVisible = false;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                RandomPozice();
                RandomHvezda();
                Thread.Sleep(2000);
            }
        }
    }
}
