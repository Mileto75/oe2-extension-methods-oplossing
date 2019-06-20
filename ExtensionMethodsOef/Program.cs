using ExtensionMethodsOef.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsOef
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a string list
            List<string> LeveranciersInfo = new List<string>();
            //We vervangen de List door onze niewe repo klasse
            //IEnumerable<Leveranciers> LeveranciersLijst = Leveranciers.getLeveranciers();
            LeveranciersRepository Lrepo = new LeveranciersRepository();
            Lrepo.FillList(Leveranciers.getLeveranciers());
            foreach (Leveranciers l in Lrepo)
            {
                LeveranciersInfo.Add($"Naam:{l?.Naam ?? "NoName"}\nAdres:{l?.Adres?.Straat} " +
                    $"{l?.Adres?.Nummer}, {l?.Adres?.PostCode} {l?.Adres?.Gemeente}" +
                    $"\nHeeftSchuld:{l?.HeeftSchuld}\nTegoed:{l?.Tegoed}");
            }
            //getting aantal Leveranciers met schuld using class method
            LeveranciersInfo.Add($"Aantal Leveranciers met schuld:{Lrepo.TelLeveranciersMetSchuld()}");

            //getting total amount of Tegoed from leveranciers repo
            //using extension method
            LeveranciersInfo.Add($"totaal Aantal Tegoed:{Lrepo.GetTotalTegoed():N0}");
            
            //getting TotalTeGoed from IEnumerable Leveranciers
            //showing that the extension method applies to all IEnumerable<Leveranciers> type
            IEnumerable<Leveranciers> Llijst = Leveranciers.getLeveranciers();
            Console.WriteLine($"TotalTegoedFromExtensionMethod: {Llijst.GetTotalTegoed():N0}");

            //Using GetByFilter extension method with Lambda expressions
         
            IEnumerable<Leveranciers> filteredLeveranciers = Llijst.GetByFilter(g => g.HeeftSchuld != true);
            //filtereredLeveranciers.count() is een Linq extension method
            Console.WriteLine($"Eer zijn {filteredLeveranciers.Count()} Leverancier(s) die schulden hebben!");
            //call the print function
            PrintLijst(LeveranciersInfo);
            Console.ReadKey();
        }
        public static void PrintLijst(List<string> lijst)
        {
            int teller = 1;
            foreach (string l in lijst)
            {
                
                Console.WriteLine("\nLeverancier " + teller.ToString());
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine(l);
                teller++;
            }
            
        }
    }
}
