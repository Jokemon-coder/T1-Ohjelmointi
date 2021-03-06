using System;

namespace harjoituksia3
{
    class Program
    {
        static void Main(string[] args)
        {
        ALKU:

            Console.WriteLine("Harjoitukset 2");
            Console.WriteLine("--------------");

            Console.WriteLine("Valitse syöttämällä kyseisen ohjelman numero:");
            Console.WriteLine("Yhteenlasku(1)");
            Console.WriteLine("Celsius-aste muunnos(2)");
            Console.WriteLine("Peruslaskut(3)");
            Console.WriteLine("Jakojäännös(4)");
            Console.WriteLine("Tervehdys(5)");
            Console.WriteLine("Kertotaulu(6)");
            Console.WriteLine("Käyttäjän ikä(7)");
            Console.WriteLine("Monikertainen tulostus(8)");
            Console.WriteLine("Etu- ja sukunimen kirjainten vaihto(9)");
            Console.WriteLine("Kokonaisluvut positiivinen ja negatiivinen(10)");
            Console.WriteLine("Lauseen pisin sana(11)");
            Console.WriteLine("Parittomat ja 3:lla jaolliset luvut(12)");
            Console.WriteLine("Sulje ohjelma(exit)");
            //Tulostaa käyttäjälle vaihtoehdot ja miten ne valitaan.

            string ohjelmat = Console.ReadLine();
            switch (ohjelmat)
            {
                case "1":
                    Console.Clear();
                    yhteenLasku(5, 9);
                    break;
                case "2":
                    Console.Clear();
                    asteMuunnos(25, 1.8, 32);
                    break;
                case "3":
                    Console.Clear();
                    perusLaskut(9, 3);
                    break;
                case "4":
                    Console.Clear();
                    jakoJaannos(8, 2);
                    break;
                case "5":
                    Console.Clear();
                    tervehdys(null, null);
                    break;
                case "6":
                    Console.Clear();
                    kertoTaulu();
                    break;
                case "7":
                    Console.Clear();
                    kayttajanIka();
                    break;
                case "8":
                    Console.Clear();
                    moniTulostus();
                    break;
                case "9":
                    Console.Clear();
                    nimiKirjainVaihto(null, null);
                    break;
                case "10":
                    Console.Clear();
                    posNegLuvut();
                    break;
                case "11":
                    Console.Clear();
                    pisinSana(null, null);
                    break;
                case "12":
                    Console.Clear();
                    parittomatLuvut();
                    break;
                case "exit": //Sulkee ohjelman, jos kirjoitetaan "exit" syöttöön.
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Et syöttänyt oikeaa numeroa tai sanaa. Paina ENTER palataksesi valikkoon.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    /*Switch-casella ohjelmien valinta valikosta. Valinta otetaan syötetyn luvun perusteella ja
                    jos syöttö on väärä luku tai tyhjä, menee defaulttiin ja aloittaa uudestaan.*/
                    
            }
            goto ALKU;
        }

        static void yhteenLasku(int luku1, int luku2)
        {
            Console.WriteLine("Valitse valmis yhteenlasku painamalla 1 tai yhteenlasku omilla luvuilla painamalla 2:");
            string versiotYT = Console.ReadLine();
            switch (versiotYT)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " summa on " + (luku1 + luku2));
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Laskee valmiit luvut yhteen ja tulostaa niiden tulon käyttäjälle. Annetaan ohjeet valikkoon palaamisesta.
                    break;
                case "2":
                ALKU1:
                    Console.WriteLine("Syötä kaksi lukua, jotta voin laskea ne yhteen:");
                    try
                    {
                        luku1 = int.Parse(Console.ReadLine());
                        luku2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja.");
                        Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                        Console.ReadLine();
                        Console.Clear();
                        goto ALKU1;
                    }//Try-catchilla tarkistetaan onko annetut luku kokonaislukuja. Jos ei ole, annetaan viesti ja palataan takaisin syöttöön gotolla.
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " summa on " + (luku1 + luku2));
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Tulostetaan luvut, joiden arvot on määritelty käyttäjän syötöllä, ja lasketaan niiden summa. Annetaan ohjeet valikkoon palaamisesta.
                    break;  
            }
        }

        static void asteMuunnos(double celsiusLuku, double kerroin, int lisays)
        {
            Console.WriteLine("Valitse valmis Celsius-asteen muunnos painamalla 1 tai oman Celcius-asteen muunnos painamalla 2:");
            string versiotAM = Console.ReadLine();
            switch (versiotAM)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(celsiusLuku + " Celsius-astetta on Fahrenheitteina " + (celsiusLuku * kerroin + lisays));
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Tehdään Celsius-asteen muunnos valmiiksi määritetyllä luvulla ja tulostetaan se käyttäjälle. Annetaan ohjeet valikkoon palaamisesta.
                    break;
                case "2":
                ALKU2:
                    Console.WriteLine("Syötä Celsius-asteet, niin muunnan ne Fahrenheiteiksi:");
                    try
                    {
                        celsiusLuku = Double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja tai desimaaleja.");
                        Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                        Console.ReadLine();
                        Console.Clear();
                        goto ALKU2;
                    }//Tarkistetaan onko luku kokonaisluku tai desimaali. Jos on, ohjelma menee eteenpäin. Jos ei ole, annetaan viesti ja palauttaa takaisin syöttöön.
                    Console.WriteLine(celsiusLuku + " Celsius-astetta on Fahrenheiteissa " + (celsiusLuku * kerroin + lisays));
                    //Tulostaa Celsius-asteen muunnoksen laskettuna

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Annetaan ohjeet valikkoon palaamisesta.
                    break;
            }
        }

        static void perusLaskut(double luku1, double luku2)
        {
            Console.WriteLine("Valitse peruslaskut valmiilla luvuilla painamalla 1 tai tee peruslaskut omilla luvuilla painamalla 2:");
            string versiotPL = Console.ReadLine();
            switch (versiotPL)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " peruslaskutoimitukset:");
                    Console.WriteLine("Summa on " + (luku1 + luku2));
                    Console.WriteLine("Erotus on " + (luku1 - luku2));
                    Console.WriteLine("Tulo on " + (luku1 * luku2));
                    Console.WriteLine("Osamäärä on " + (luku1 / luku2));

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Tehdään peruslaskut valmiiksi määritetyillä luvuilla ja tulostetaan ne käyttäjälle.
                    break;
                case "2":
                ALKU3:
                    Console.WriteLine("Syötä kaksi kokonaislukua:");
                    try
                    {
                        luku1 = Double.Parse(Console.ReadLine());
                        luku2 = Double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain numeroita, kiitos.");
                        Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                        Console.ReadLine();
                        Console.Clear();
                        goto ALKU3;
                    }
                    //Katsotaan onko luvut numeroita (kokonais- tai doublelukuja). Doublelukuja sen takia, koska pystytään siten tulostamaan myös desimaalilukuja vastauksissa.
                    //Jos ei ole numeroita, ohjeet ja palaaminen syöttöön.

                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " peruslaskutoimitukset:");
                    Console.WriteLine("Summa on " + (luku1 + luku2));
                    Console.WriteLine("Erotus on " + (luku1 - luku2));
                    Console.WriteLine("Tulo on " + (luku1 * luku2));
                    Console.WriteLine("Osamäärä on " + (luku1 / luku2));
                    //Peruslaskut tulostetaan syötettyjä lukuja käyttäen.

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Ohjeet ja palataan alkuvalikkoon.
                    break;
            }
        }

        static void jakoJaannos(int luku1, int luku2)
        {
            Console.WriteLine("Valitse jakojäännös valmiilla luvuilla painamalla 1 tai jakojäännös omilla luvuilla painamalla 2:");
            string versiotJJ = Console.ReadLine();
            switch (versiotJJ)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " jakojäännös on " + (luku1 % luku2));

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Tehdään ja tulostetaan lasku valmiilla luvuilla. Ohjeet ja palaaminen alkuvalikkoon.
                    break;
                case "2":
                ALKU4:
                    Console.WriteLine("Syötä kaksi lukua, niin annan niiden jakojäännöksen:");
                    try
                    {
                        luku1 = int.Parse(Console.ReadLine());
                        luku2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja, kiitos.");
                        Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                        Console.ReadLine();
                        Console.Clear();
                        goto ALKU4;
                    }
                    //Katsotaan että syötetyt arvot ovat kokonaislukuja. Jos on, jatketaan. Jos ei, viesti ja palaaminen syöttöön.
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " jakojäännös on " + (luku1 % luku2));
                    //Tehdään ja tulostetaan lasku syötetyillä luvuilla.

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Ohjeet ja palaaminen alkuvalikkoon.
                    break;
            }
        }

        static void tervehdys(string etuNimi, string sukuNimi)
        {

            Console.WriteLine("Syötä etun- ja sukunimesi:");

        ALKU1:
            Console.Write("Etunimi:");
            etuNimi = Console.ReadLine();
            if (etuNimi == "") //Jos syöttö on tyhjä, viesti tyhjästä syötöstä ja takaisin syöttöön. Muuten jatkuu eteenpäin.
            {
                Console.WriteLine("En ota vastaan tyhjää kenttää.");
                goto ALKU1;
            }else
            {
            ALKU2:
                Console.Write("Sukunimi:");
                sukuNimi = Console.ReadLine();
                if (sukuNimi == "") //Jos syöttö on tyhjä, viesti tyhjästä syötöstä ja takaisin syöttöön. Muuten jatkuu eteenpäin.
                {
                    Console.WriteLine("En ota vastaan tyhjää kenttää.");
                    goto ALKU2;
                }else
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Hei " + etuNimi + " " + sukuNimi + "!");
                    //Tulostetaan tervehdys ja lisätään annetut nimet siihen.
                }
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Ohje ja paluu alkuvalikkoon.
        }

        static void kertoTaulu()
        {
        ALKU6:
            int kerrottavaLuku, kerroin;
            Console.Write("Syötä luku 1 - 10 väliltä: ");
            try
            {
                kerrottavaLuku = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Syötä vain numeroita, kiitos.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU6;
            }//Muuntaa annetun luvun Int32:ksi. Antaa virheen, jos annettu arvo ei ole numero.


            if (kerrottavaLuku < 1) //Jos luku on pienempi kuin 0, tulee viesti ja palaaminen syöttöön. Muuten eteenpäin.
            {
                Console.WriteLine("En ota lukua 0 tai pienempää vastaan.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU6;
            } else if (kerrottavaLuku > 10) //Muuten jos luku on suurempi kuin 10, viesti ja paluu syöttöön. Muuten loppuun asti.
            {
                Console.WriteLine("En ota suurempaa lukua kuin 10 vastaan.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU6;
            } else //Jos luku on ollut suurempi kuin 0 ja pienempi kuin 11, lasketaan ja tulostetaan luvun kertotaulu for-loopin avulla.
                for (kerroin = 1; kerroin <= 10; kerroin++) //Kerroin on 1 ja kerroin on pienempi tai yhtä suuri kuin 10. 
                {
                    Console.WriteLine("{0} x {1} = {2}", kerrottavaLuku, kerroin, (kerrottavaLuku * kerroin));
                    //Laskee ja tulostaa syötetyn luvun kertotaulun käyttäen kerrointa.
                }
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Ohjeet ja paluu alkuvalikkoon.
        }

        static void kayttajanIka()
        {
        ALKU7:
            int ika;
            Console.Write("Syötä ikäsi: ");
            try
            {
                ika = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU7;
            }//Katsotaan onko syötetty arvo kokonaisluku. Jos ei, viesti ja paluu syöttöön.
            if (ika < 0) //Jos annettu luku on pienempi kuin 0, viesti ja paluu syöttöön. Muuten menee eteenpäin.
            {
                Console.WriteLine("Ei voi olla negatiivinen ikä.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU7;
            }
            else
            {
                Console.WriteLine(ika + "?" + " Näytät ikäistäsi nuoremmalta.");
                Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                Console.ReadLine();
                Console.Clear();
                //Lisätään annettu ikä lauseeseen ja tulostetaan. Ohje ja paluu alkuvalikkoon.
            }
        }

        static void moniTulostus()
        {
        ALKU8:
            int kayttajanLuku;
            Console.WriteLine("Syötä jokin luku suurempi kuin 10: ");
            try
            {
                kayttajanLuku = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU8;
            }//Katsotaan onko syötetty arvo kokonaisluku. Jos ei, viesti ja paluu syöttöön.
            if (kayttajanLuku < 10) //Jos annettu luku on pienempi kuin 10, viesti ja paluu syöttöön.
            {
                Console.WriteLine("En ota vastaan lukuja alle 10.");
                Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU8;
            } else
                for (int i = 0; i < kayttajanLuku; i++) //For-loopin avulla tulostetaan käyttäjän luku yhtä monta kertaa kuin sen arvo.
                {
                    Console.Write(kayttajanLuku);
                }
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Ohje ja paluu alkuvalikkoon.
        }

        static void nimiKirjainVaihto(string etuNimi, string sukuNimi)
        {
            Console.WriteLine("Syötä etun- ja sukunimesi:");

        ALKU1:
            Console.Write("Etunimi:");
            etuNimi = Console.ReadLine();
            if (etuNimi == "") //Jos syöttö on tyhjä, viesti ja paluu syöttöön.
            {
                Console.WriteLine("En ota vastaan tyhjää kenttää.");
                goto ALKU1;
            }
            else
            {
            ALKU2:
                Console.Write("Sukunimi:");
                sukuNimi = Console.ReadLine();
                if (sukuNimi == "") //Jos syöttö on tyhjä, viesti ja paluu syöttöön.
                {
                    Console.WriteLine("En ota vastaan tyhjää kenttää.");
                    goto ALKU2;
                }
                else //Jos kentät eivät ole tyhjiä, vaihdetaan ensimmäinen ja viimeinen kirjain keskenään molemmista nimistä.
                    Console.WriteLine((etuNimi.Length > 1 ? etuNimi.Substring(etuNimi.Length - 1) + etuNimi.Substring(1, etuNimi.Length - 2) + etuNimi.Substring(0, 1) : etuNimi) + " " +
                    (sukuNimi.Length > 1 ? sukuNimi.Substring(sukuNimi.Length - 1) + sukuNimi.Substring(1, sukuNimi.Length - 2) + sukuNimi.Substring(0, 1) : etuNimi));
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Ohje ja paluu alkuvalikkoon.
        }

        static void posNegLuvut()
        {
        ALKU9:
            int luku1;
            int luku2;
            Console.WriteLine("Syötä kaksi lukua:");
            try
            {
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja.");
                Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU9;
            }//Jos annetut arvot eivät ole kokonaislukuja, viesti ja paluu syöttöön.

            if (luku1 > 0 && luku2 > 0) //Jos molemmat luvut ovat suurempia kuin 0, ne ovat positiivisia.
            {
                Console.WriteLine("Molemmat ovat positiivisia.");
            }
            else if (luku1 < 0 && luku2 < 0) //Muuten jos ne ovat pienempiä kuin 0, ne ovat negatiivisia.
            {
                Console.WriteLine("Molemmat ovat negatiivisia.");
            }
            else if (luku1 == 0 || luku2 == 0) //Muuten jos jompikumpi on 0, viesti ja paluu syöttöön.
            {
                Console.WriteLine("Älä syötä nollia, kiitos.");
                Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU9;
            }
            else //Muussa tapauksessa toinen on positiivinen ja toinen on negatiivinen.
                Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen.");

            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Ohje ja paluu alkuvalikkoon.
        }

        static void pisinSana(string lause, string[] lauseenSanat)
        {
        ALKU10:
            Console.WriteLine("Syötä lause:");
            lause = Console.ReadLine();
            lauseenSanat = lause.Split(" "); //Sana loppuu ja uusi alkaa välilyönnillä.
            string pisinSana = ""; //Pisin sana on aluksi tyhjä.

            for (int i = 0; i < lauseenSanat.Length; i += 1)
            {
                string yksiSana = lauseenSanat[i]; //Yksittäinen sana on stringistä "lauseenSanat"
                if (yksiSana.Length > pisinSana.Length) //Jos yksittäinen sana on pituudelta pidempi kuin pisin sana, siitä tulee uusi pisin sana.
                {
                    pisinSana = yksiSana;
                }
                else if (pisinSana.Length == 0) //Muuten jos syötetään tyhjää, viesti ja paluu syöttöön.
                {
                    Console.WriteLine("En ota vastaan tyhjää.");
                    Console.WriteLine("Paina ENTER palataksesi syöttöön:");
                    Console.ReadLine();
                    Console.Clear();
                    goto ALKU10;
                }

            }
            Console.WriteLine("Lauseen pisin sana: " + pisinSana);
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
            //Annetaan syötetyn lauseen pisin sana. Ohje ja paluu alkuvalikkoon.
        }

        static void parittomatLuvut()
        {
            Console.WriteLine("Valitse ohjelma syöttäen numero:");
            Console.WriteLine("Parittomat luvut 1-99(1)");
            Console.WriteLine("3:lla jaolliset luvut 1-99(2)");
            string ohjelmat = Console.ReadLine();
            switch (ohjelmat)
            //Ohjelman valinta switch-casella ja annetulla numerolla.
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Parittomat luvut 1-99 väliltä:");
                    for (int n = 1; n < 100; n++) //n on 1 ja pienempi kuin 100.
                    {
                        if (n % 2 != 0) //n jakojäännös 2 ei ole yhtäsuuri kuin 0, antaa parittomat luvut 1-99.
                        {
                            Console.WriteLine(n.ToString());
                        }
                    }
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Ohje ja paluu alkuvalikkoon.
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("3:lla jaolliset luvut 1-99 väliltä:");
                    for (int n = 1; n < 100; n++) //n on 1 ja pienempi kuin 100.
                    {
                        if (n % 3 == 0) //n jakojäännös 3 == 0, antaa 3:lla jaolliset 1-99.
                        {
                            Console.WriteLine(n.ToString());
                        }
                    }
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    //Ohje ja paluu alkuvalikkoon.
                    break;
            }
        }
    }
}

