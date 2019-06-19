using ExtensionMethodsOef.Models;
using System;
using System.Collections.Generic;

namespace ExtensionMethodsOef
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a string list
            List<string> LeveranciersInfo = new List<string>();
            IEnumerable<Leveranciers> LeveranciersLijst = Leveranciers.getLeveranciers();
            foreach(Leveranciers l in LeveranciersLijst)
            {
                LeveranciersInfo.Add($"Naam:{l.Naam}\nAdres:{l.Adres.Straat} {l.Adres.Nummer}, {l.Adres.PostCode} {l.Adres.Gemeente}" +
                    $"\nHeeftSchuld:{l.HeeftSchuld}\nTegoed:{l.Tegoed}");
            }

            foreach(string l in LeveranciersInfo)
            {
                Console.WriteLine(l);
            }
            //PrintLijst(LeveranciersInfo);
            Console.ReadKey();
        }
        public static void PrintLijst(List<string> lijst)
        {
            foreach(string l in lijst)
            {
                Console.WriteLine(l);
            }
        }
    }
}
