using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SbirkaUlohVTS
{
    /*Napište program, který zkopíruje obsah souboru stary.txt do souboru novy.txt. Navíc 
    *převede velká písmena na malá, vypustí číslice a místo mezer přejde vždy na nový řádek.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string adresa = @"\\regulus2\users$\xott\temp\řádekpořádku.txt";
            string adresa2 = @"\\regulus2\users$\xott\temp\kopie.txt";
            FileStream original = new FileStream(adresa, FileMode.Open);
            FileStream kopie = new FileStream(adresa2, FileMode.Create);
            StreamReader sr = new StreamReader(original);
            StreamWriter sw = new StreamWriter(kopie);

            StringBuilder text = new StringBuilder();
            int pismeno;
            while ((pismeno = sr.Read()) != -1)
            {
                if (pismeno >= 48 && pismeno <= 57)
                    continue;
                if ((char)pismeno == ' ')
                {
                    text.Append("\n");
                    continue;
                }
                text.Append(((char)pismeno).ToString().ToLower());
            }
            sw.Write(text.ToString());
            sw.Flush();
            sw.Close();
            sr.Close();
            original.Close();
            kopie.Close();
            
        }
    }
}
