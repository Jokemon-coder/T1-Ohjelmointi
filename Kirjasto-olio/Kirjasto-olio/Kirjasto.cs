using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto_olio
{
    class Kirjasto
    {
        private string _kirjanNimi = "";
        private string _kirjailija = "";
        private int _julkaisuVuosi = 0;
        private int _sivuMaara = 0;
        //Yksityiset kentät

        public string kirjanNimi { get { return _kirjanNimi; } }
        public string kirjailija { get { return _kirjailija; } }
        public int julkaisuVuosi { get { return _julkaisuVuosi; } }
        public int sivuMaara { get { return _sivuMaara; } }
        //Julkiset kentät

        public Kirjasto(string kirjanNimi, string kirjailija, int julkaisuVuosi, int sivuMaara)
        {
            _kirjanNimi = kirjanNimi;
            _kirjailija = kirjailija;
            _julkaisuVuosi = julkaisuVuosi;
            _sivuMaara = sivuMaara;
        }//Konstruktori
    }
}
