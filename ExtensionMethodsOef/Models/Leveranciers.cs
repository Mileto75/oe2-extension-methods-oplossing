using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public class Leveranciers
    {
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public bool HeeftSchuld { get; set; } = false;
        public int Tegoed { get; set; }

        public static Leveranciers[] getLeveranciers()
        {
            Leveranciers l1 = new Leveranciers {Naam="Hubo",Adres = new Adres("Langestraat","67","Blankenberge","8370"),Tegoed=4589 };
            Leveranciers l2 = new Leveranciers { Naam = "Carrefour", Adres = new Adres("Steenweg", "123", "Gent", "9000"),HeeftSchuld=true, Tegoed = 14589 };
            Leveranciers l3 = new Leveranciers { Naam = "Delhaize", Adres = new Adres("Molenstraat", "6", "Brugge", "8000"), Tegoed = 45699 };
            Leveranciers l4 = new Leveranciers { Naam = "Colruyt", Adres = new Adres("Legeweg", "167", "Gent", "9000"), Tegoed = 11000};
            Leveranciers l5 = new Leveranciers { Naam = "AlbertHeijn", Adres = new Adres("Kerkstraat", "2", "Brugge", "8000"), Tegoed = 8654};
            return new Leveranciers[] { l1, l2, l3, l4,l5 };
        }

    }
}
