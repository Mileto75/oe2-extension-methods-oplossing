using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public class LeveranciersRepository :IEnumerable<Leveranciers>
    {
        //protecting LeveranciersLijst from outside access
        private IEnumerable<Leveranciers> LeveranciersLijst;

        public IEnumerator<Leveranciers> GetEnumerator()
        {
            return LeveranciersLijst.GetEnumerator();
        }

        /**
         * fills the leverancierslijst
         */
        public void FillList(IEnumerable<Leveranciers> Lijst)
        {
            LeveranciersLijst = Lijst;
        }

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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LeveranciersLijst.GetEnumerator();
        }
    }
}
