using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public class LeveranciersRepository
    {
        public IEnumerable<Leveranciers> LeveranciersLijst { get; set; }

        public int TelLeveranciersMetSchuld()
        {
            int Totaal = 0;
            foreach (Leveranciers l in LeveranciersLijst)
            {
                if (l.HeeftSchuld == true)
                {
                    Totaal++;
                }
            }
            return Totaal;
        }
    }
}
