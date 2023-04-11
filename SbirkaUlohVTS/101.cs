using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUlohVTS
{
    //Cyklem for načtěte matici typu m x n podle zadání uživatele a vytiskněte cyklem foreach.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte rozměry matice!");
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++) //řádky
            {
                Console.WriteLine("Zadejte hodnoty {0}. řádku.", i);
                for (int j = 0; j < n; j++)
                {
                    Console.Write("A{0}{1}: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int pocitadlo = 0;
            foreach (int a in matrix)
            {
                Console.Write("{0}\t", a);
                if (++pocitadlo % n == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
