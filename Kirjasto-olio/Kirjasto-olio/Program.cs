using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto_olio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tiedosto = LueTiedosto("arvot.csv");//Määritellään mistä tiedot luetaan.
            List<Kirjasto> kirjat = new List<Kirjasto>();//Lista kirjat on uusi lista.

            kirjat = HaeKirjat(tiedosto);//Haetaan kirjat ja niiden arvot.
            TulostaKirjat(kirjat);//Tulostetaan kirjat.
            Console.ReadKey();


        }

        static string[] LueTiedosto(string tiedostonimi)
        {
            string[] rivit = System.IO.File.ReadAllLines(tiedostonimi);
            return rivit;
        }//Lukee tiedostosta ja palauttaa rivit.

        static List<Kirjasto> HaeKirjat(string[] tiedosto)
        {
            Dictionary<int, List<string>> tiedosto_esineet = new Dictionary<int, List<string>>();
            List<Kirjasto> kirjat = new List<Kirjasto>();
            
            for (int i = 0; i < tiedosto.Length; i++) tiedosto_esineet.Add(i, HaeEsineet(tiedosto[i]));
            //Haetaan esineet tiedostosta.

            for (int i = 1; i < tiedosto.Length; i++)//Luodaan kirjaston oliot.
            {
                Kirjasto k;
                string kirjannimi = "", kirjailija = "";
                int julkaisuvuosi = 0;
                int sivumaara = 0;
                //Määritellään perusarvot.
                
                for (int j = 0; j < tiedosto_esineet[0].Count(); j++)
                {
                    
                    switch(tiedosto_esineet[0][j].ToLower())
                    {
                        case "kirjannimi":
                            kirjannimi = tiedosto_esineet[i][j];
                            break;
                        case "kirjailija":
                            kirjailija = tiedosto_esineet[i][j];
                            break;
                        case "julkaisuvuosi":
                            julkaisuvuosi = int.Parse(tiedosto_esineet[i][j]);
                            break;
                        case "sivumaara":
                            sivumaara = int.Parse(tiedosto_esineet[i][j]);
                            break;
                        default:
                            Console.WriteLine($"Header '{tiedosto_esineet[0][j]}' ei käy");
                            break;
                    }//Tarkistetaan missä arvossa ollaan. Jos jokin on väärin, tulee viesti.
                }

                k = new Kirjasto(kirjannimi, kirjailija, julkaisuvuosi, sivumaara);
                kirjat.Add(k);
                //Luodaan uusi olio ja lisätään se listaan.
            }
            return new List<Kirjasto>(kirjat);
            //Palauttaa uuden listan
        }

        static List<string> HaeEsineet(string rivi)
        {
            string nykyinen_sana = "";
            List<string> esineet = new List<string>();

            foreach(char c in rivi)
            {
                if (c == ',')
                {
                    if (nykyinen_sana != "")
                    {
                        esineet.Add(nykyinen_sana);
                        nykyinen_sana = "";
                    }
                //Jos c on pilkku, katsotaan onko nykyinen_sana tyhjä ja jos on, lisätään nykyinen_sana listaan ja lausutaan se tyhjäksi.
                }else
                {
                    nykyinen_sana += c.ToString();
                }
                //Muuten nykyinen_sana lisätään stringiin
            }

            if (nykyinen_sana != "") esineet.Add(nykyinen_sana);
            //Jos nykyinen_sana ei ole tyhjä, lisätään se "esineet" listaan.
            
            return new List<string>(esineet);
            //Palautetaan uusi lista.
        }

        static void TulostaKirjat(List<Kirjasto> kirjat)
        {
            foreach (Kirjasto k in kirjat)
            {
                Console.WriteLine($"{k.kirjanNimi}n on kirjoittanut {k.kirjailija} ja se on julkaistu vuonna {k.julkaisuVuosi.ToString()}. Kirjassa on {k.sivuMaara.ToString()} sivua.");
                //Tulostetaan kirjat.
            }
        }
    }
}
