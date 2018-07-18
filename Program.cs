using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kontoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            {

            }
            //Benutzereingabe();
            StreamReader sr01 = new StreamReader("..\\..\\Kontostand.txt");
            string s;
            while ((s = sr01.ReadLine()) != null)
                Console.WriteLine(s);
            {
                sr01.Dispose();
                sr01.Close();
                Console.ReadKey();
            }
                {
                Console.WriteLine(sr01.ReadLine());
            }
            Console.ReadKey();
        }
        private static void Benutzereingabe()
        {
            {
                double zahl1, ergebnis;
                string operand;

                Console.WriteLine("Bitte addieren oder subtrahieren Sie den gewünschten Betrag");
                zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte wählen Sie den Operand aus:");
                operand = Console.ReadLine();

                if (operand == "+")
                {
                    ergebnis = +zahl1;
                }
                else if (operand == "-")
                {
                    ergebnis = -zahl1;
                }
                Console.WriteLine("Führen Sie eine Aktion aus oder schließen Sie mit 0");
                Console.ReadKey();

            }
            StreamWriter sw01 = new StreamWriter("..\\..\\Kontostand.txt");
            string input = "";
            while (input != "0")
            {
                Console.WriteLine("Texzeile in Datei schreiben: ");
                input = Console.ReadLine();
                sw01.WriteLine(input);
                Console.WriteLine("\nZum Beenden 0 eingeben:: ");
                input = Console.ReadLine();
            }
            sw01.Flush();
            sw01.Close();
        }
    }
}
