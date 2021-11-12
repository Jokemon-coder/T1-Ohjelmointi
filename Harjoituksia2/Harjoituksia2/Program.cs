using System;

namespace Harjoituksia2
{
    class Program
    {
        static void Main(string[] args)
        {
        ALKU:

            Console.WriteLine("Harjoitukset 2");
            Console.WriteLine("--------------");

            Console.WriteLine("Valitse syöttämällä kyseisen ohjelman numero:");
            Console.WriteLine("Ohjelma 1");
            Console.WriteLine("Ohjelma 2");
            Console.WriteLine("Ohjelma 3");
            Console.WriteLine("Ohjelma 4");
            Console.WriteLine("Ohjelma 5");
            Console.WriteLine("Ohjelma 6");

            string ohjelmat = Console.ReadLine();
            switch (ohjelmat)
            {
                case "1":
                    Console.Clear();
                    ohjelma1();
                    break;
                case "2":
                    Console.Clear();
                    ohjelma2();
                    break;
                case "3":
                    Console.Clear();
                    ohjelma3();
                    break;
                case "4":
                    Console.Clear();
                    ohjelma4();
                    break;
                case "5":
                    Console.Clear();
                    ohjelma5();
                    break;
                case "6":
                    Console.Clear();
                    ohjelma6();
                    break;
               default:
                    Console.Clear();
                    Console.WriteLine("Et syöttänyt oikeaa numeroa. Paina ENTER palataksesi valikkoon.");
                    Console.ReadLine();
                    Console.Clear();
                    break; 
            }

            goto ALKU;
        }

        static void ohjelma1()
        {
        ALKU1:
            int luku1;
            int luku2;

            Console.WriteLine("Syötä kaksi kokonaislukua, jotta voin järjestää ne suuruusjärjestykseen:");
            try
            {
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                Console.WriteLine("---------------------------------");
                goto ALKU1;
            }

            if (luku1 > luku2)
            {
                Console.WriteLine(luku1 + " " + luku2);
            }
            else if (luku1 < luku2)
            {
                Console.WriteLine(luku2 + " " + luku1);
            }
            else
            {
                Console.WriteLine("Luvut ovat yhtä suuria");
            }

            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();

        }

        static void ohjelma2()
        {
        ALKU2:
            int luku1;
            int luku2;
            int luku3;
            Console.WriteLine("Syötä kolme kokonaislukua, jotta voin etsiä niistä suurimman");

            try
            {
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
                luku3 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                Console.WriteLine("---------------------------------");
                goto ALKU2;
            }

            int suurin = luku1;
            if (luku2 > suurin) suurin = luku2;
            if (luku3 > suurin) suurin = luku3;
            if (luku1 == luku2)
            {
                if (luku2 == luku3)
                {
                    Console.WriteLine("Kaikki luvut ovat samanarvoisia");
                }

            }
            else
            {
                Console.WriteLine(suurin + " on suurin");
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();
        }

        static void ohjelma3()
        {
        ALKU3:
            Console.Clear();
            Console.WriteLine("Anna numero 0 ja 9 väliltä, jotta voin muuttaa sen sanaksi");

            int numero = Convert.ToInt32(Console.ReadLine());
            string nimi = "";
            switch (numero)
            {

                case 0:
                    nimi = "Nolla";
                    break;
                case 1:
                    nimi = "Yksi";
                    break;
                case 2:
                    nimi = "Kaksi";
                    break;
                case 3:
                    nimi = "Kolme";
                    break;
                case 4:
                    nimi = "Neljä";
                    break;
                case 5:
                    nimi = "Viisi";
                    break;
                case 6:
                    nimi = "Kuusi";
                    break;
                case 7:
                    nimi = "Seitsemän";
                    break;
                case 8:
                    nimi = "Kahdeksan";
                    break;
                case 9:
                    nimi = "Yhdeksän";
                    break;
                default:
                    Console.WriteLine("Annoit väärän luvun, yritä uudelleen painamalla ENTER");
                    Console.ReadLine();
                    Console.Clear();
                    goto ALKU3; 

            }
            Console.WriteLine(nimi);
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();

        }
        static void ohjelma4()
        {
        ALKU4:
            int luku1;
            int luku2;
            int luku3;
            int luku4;
            int luku5;
            Console.WriteLine("Syötä viisi kokonaislukua, jotta voin etsiä niistä suurimman");

            try
            {
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
                luku3 = int.Parse(Console.ReadLine());
                luku4 = int.Parse(Console.ReadLine());
                luku5 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                Console.WriteLine("---------------------------------");
                goto ALKU4;
            }

            int suurin = luku1;
            if (luku2 > suurin) suurin = luku2;
            if (luku3 > suurin) suurin = luku3;
            if (luku4 > suurin) suurin = luku4;
            if (luku5 > suurin) suurin = luku5;
            if (luku1 == luku2)
            {
                if (luku2 == luku3)
                {
                    if (luku3 == luku4)
                    {
                        if (luku4 == luku5)
                        {
                            Console.WriteLine("Kaikki luvut ovat samanarvoisia");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(suurin + " on suurin");
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();


        }

        static void ohjelma5()
        {
        ALKU5:
            int kokonaisLuku;
            double doubleLuku;
            string merkkiJono;
            Console.WriteLine("Valitse syötettävä arvo:");
            Console.WriteLine("Paina 1, jos haluat syöttää kokonaisluvun");
            Console.WriteLine("Paina 2, jos haluat syöttää double-luvun");
            Console.WriteLine("Paina 3, jos haluat syöttää merkkijonon");

            string luvut = Console.ReadLine();
            switch (luvut)
            {
                case "1":
                    Console.WriteLine("Syötä kokonaisluku:");
                    try
                    {
                        kokonaisLuku = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                        Console.WriteLine("---------------------------------");
                        goto ALKU5;
                    }
                    Console.Clear();
                    int resultKoko = kokonaisLuku + 1;
                    Console.WriteLine("Kasvatin antamaasi lukua yhdellä. Se on nyt " + resultKoko + ".");
                    break;
                case "2":
                    Console.WriteLine("Syötä double-luku:");
                    try
                    {
                        doubleLuku = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Syötä vain double-lukuja, kiitos");
                        Console.WriteLine("--------------------------------");
                        goto ALKU5;
                    }
                    Console.Clear();
                    double resultDouble = doubleLuku + 1;
                    Console.WriteLine("Kasvating antamaasi lukua yhdellä. Se on nyt " + resultDouble + ".");
                    break;
                case "3":
                    Console.WriteLine("Syötä merkkijono:");
                    merkkiJono = Console.ReadLine();
                    char merkki = '*';
                    string resultMerkki = new string(merkkiJono += merkki);
                    Console.WriteLine("Lisäsin merkin * syöttämääsi merkkijonoon. Se on nyt " + resultMerkki + ".");
                    break;
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();
        }

        static void ohjelma6()
        {
        ALKU6:
            Console.WriteLine("Syötä luku 1-9:");

            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Pisteesi ovat nyt " + (1 * 10));
                    break;
                case 2:
                    Console.WriteLine("Pisteesi ovat nyt " + (2 * 10));
                    break;
                case 3:
                    Console.WriteLine("Pisteesi ovat nyt " + (3 * 10));
                    break;
                case 4:
                    Console.WriteLine("Pisteesi ovat nyt " + (4 * 100));
                    break;
                case 5:
                    Console.WriteLine("Pisteesi ovat nyt " + (5 * 100));
                    break;
                case 6:
                    Console.WriteLine("Pisteesi ovat nyt " + (6 * 100));
                    break;
                case 7:
                    Console.WriteLine("Pisteesi ovat nyt " + (7 * 1000));
                    break;
                case 8:
                    Console.WriteLine("Pisteesi ovat nyt " + (8 * 1000));
                    break;
                case 9:
                    Console.WriteLine("Pisteesi ovat nyt " + (9 * 1000));
                    break;
                default:
                    Console.WriteLine("Syötä vain kokonaislukuja, jotka ovat väliltä 1-9. Paina ENTER yrittääksesi uudelleen.");
                    Console.ReadLine();
                    Console.Clear();
                    goto ALKU6;

            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();
        }


    }
}


