using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public static class LeveranciersRepositoryExtensions
    {
        /**
         * this function extends the LeveranciersRepository class
         * with a method to calculate and return the totaal amount of Tegoed
         */
        public static int GetTotalTegoed(this LeveranciersRepository Lrepo)
        {
            int TotaalTeGoed = 0;
            foreach(Leveranciers l in Lrepo)
            {
                TotaalTeGoed += l.Tegoed;
            }
            return TotaalTeGoed;
        }
    }
}
