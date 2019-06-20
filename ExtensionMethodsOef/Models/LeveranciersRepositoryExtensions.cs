using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public static class LeveranciersRepositoryExtensions
    {
        /**
         * this function extends the IEnumerable<Leveranciers> type
         * with a method to calculate and return the totaal amount of Tegoed
         * all classes implementing IEnumerable<Leveranciers> will have access to
         * these extension methods
         */
         /**
          * Calculates total Tegoed for all Leveranciers
          */
        public static int GetTotalTegoed(this IEnumerable<Leveranciers> Lrepo)
        {
            int TotaalTeGoed = 0;
            foreach(Leveranciers l in Lrepo)
            {
                TotaalTeGoed += l.Tegoed;
            }
            return TotaalTeGoed;
        }

        public static List<Leveranciers> GetByMinimumTegoed(this IEnumerable<Leveranciers> Llijst,int minimumTeGoed)
        {
            List<Leveranciers> LeveranciersMetMinimumTeGoed =  new List<Leveranciers>();
            foreach(Leveranciers l in Llijst)
            {
                if(l.Tegoed > minimumTeGoed)
                {
                    LeveranciersMetMinimumTeGoed.Add(l);
                }
            }
            return LeveranciersMetMinimumTeGoed ;
        }

        /**
         * generic filter method
         */
        public static IEnumerable<Leveranciers> GetByFilter(this IEnumerable<Leveranciers> Llijst, Func<Leveranciers, bool> result)
        {
            foreach(Leveranciers l in Llijst)
            {
                if(result(l))
                {
                    yield return l;
                }
            }
        }


    }
}
