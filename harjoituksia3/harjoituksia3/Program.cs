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
            Console.WriteLine("Harjoitus 1");
            Console.WriteLine("Harjoitus 2");
            Console.WriteLine("Harjoitus 3");
            Console.WriteLine("Harjoitus 4");
            Console.WriteLine("Harjoitus 5");
            Console.WriteLine("Harjoitus 6");
            //Tulostaa käyttäjälle vaihtoehdot ja miten ne valitaan.

            string ohjelmat = Console.ReadLine();
            switch (ohjelmat)
            {
                case "1":
                    Console.Clear();
                    harjoitus1();
                    break;
                case "2":
                    Console.Clear();
                    harjoitus2(1.8, 32);
                    break;
                case "3":
                    Console.Clear();
                    harjoitus3();
                    break;
                case "4":
                    Console.Clear();
                    
                    break;
                case "5":
                    Console.Clear();
                    
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

        static void harjoitus1()
        {
        ALKU1:
            int luku1;
            int luku2;

            Console.WriteLine("Syötä kaksi lukua, jotta voin laskea ne yhteen:");
            try
            {
                luku1 = int.Parse(Console.ReadLine());
            }catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja.");
                goto ALKU1;
            }
            try
            {
                luku2 = int.Parse(Console.ReadLine());
            }catch
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
        }

        static void harjoitus2(double kerroin, int lisays)
        {
        ALKU2:
            double celsiusLuku;

            Console.WriteLine("Syötä Celsius-asteet, niin muunnan ne Fahrenheiteiksi:");
            try
            {
                celsiusLuku = Double.Parse(Console.ReadLine());
            }catch
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

        }

        static void harjoitus3()
        {
        ALKU3:
            
            double luku1;
            double luku2;
            
            Console.WriteLine("Syötä kaksi kokonaislukua:");
            try
            {
                luku1 = Double.Parse(Console.ReadLine());
                luku2 = Double.Parse(Console.ReadLine());
            }catch
            {
                Console.WriteLine("Syötä vain numeroita, kiitos.");
                Console.WriteLine("Paina ENTER yrittääksesi uudelleen:");
                Console.ReadLine();
                Console.Clear();
                goto ALKU3;
            }

            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " peruslaskutoimitukset:");
            Console.WriteLine("Summa on " + (luku1 + luku2));
            Console.WriteLine("Vähennys on " + (luku1 - luku2));
            Console.WriteLine("Kerto on " + (luku1 * luku2));
            Console.WriteLine("Jako on " + (luku1 / luku2));

            Console.WriteLine("Paina ENTER palataksesi valikkoon:");
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}
