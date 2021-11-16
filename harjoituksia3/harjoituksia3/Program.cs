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
            Console.WriteLine("Harjoitus(6)");
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
                    
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Et syöttänyt oikeaa numeroa. Paina ENTER palataksesi valikkoon.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    // Switch-casella ohjelmien valinta valikosta. 
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
                    break;
                case "2":
                ALKU1:
                    Console.WriteLine("Syötä kaksi lukua, jotta voin laskea ne yhteen:");
                    try
                    {
                        luku1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja.");
                        goto ALKU1;
                    }
                    try
                    {
                        luku2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja.");
                        Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                        Console.ReadLine();
                        Console.Clear();
                        goto ALKU1;

                    }
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " summa on " + (luku1 + luku2));
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
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
                    }
                    Console.WriteLine(celsiusLuku + " Celsius-astetta on Fahrenheiteissa " + (celsiusLuku * kerroin + lisays));
                    
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
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

                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " peruslaskutoimitukset:");
                    Console.WriteLine("Summa on " + (luku1 + luku2));
                    Console.WriteLine("Erotus on " + (luku1 - luku2));
                    Console.WriteLine("Tulo on " + (luku1 * luku2));
                    Console.WriteLine("Osamäärä on " + (luku1 / luku2));

                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
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
                    Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " jakojäännös on " + (luku1 % luku2));
                    
                    Console.WriteLine("Paina ENTER palataksesi valikkoon:");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }


        }

        static void tervehdys(string etuNimi, string sukuNimi)
        {
            
            Console.WriteLine("Syötä etun- ja sukunimesi:");

            ALKU1:
            Console.Write("Etunimi:");
            etuNimi = Console.ReadLine();
            if (etuNimi == "")
            {
                Console.WriteLine("En ota vastaan tyhjää kenttää.");
                goto ALKU1;
            }
            else
            {
            ALKU2:
            Console.Write("Sukunimi:");
            sukuNimi = Console.ReadLine();
            if (sukuNimi == "")
            {
                Console.WriteLine("En ota vastaan tyhjää kenttää.");
                goto ALKU2;
            }else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Hei " + etuNimi + " " + sukuNimi + "!");
            }
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}

