using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsOef.Models
{
    public class Adres
    {
        public string Straat { get; set; }
        public string Nummer { get; set; }
        public string Gemeente { get; set; }
        public string PostCode { get; set; }

        public Adres(string strt, string nr, string gmnte, string pstcd)
        {
            Straat = strt;
            Nummer = nr;
            Gemeente = gmnte;
            PostCode = pstcd;
        }
    }
}
