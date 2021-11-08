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
            Console.WriteLine("Ohjelma 7");

            string ohjelmat = Console.ReadLine();
            switch (ohjelmat)
            {
                case "1":
                    Console.Clear();
                    ohjelma1(0, 1);
                    break;
                case "2":
                    Console.Clear();
                    ohjelma2(0, 1, 2);
                    break;
                case "3":
                    Console.Clear();
                    ohjelma3();
                    break;
                case "4":
                    Console.Clear();
                    ohjelma4(0, 0, 0, 0, 0);
                    break;
                case "5":
                    Console.Clear();

                    break;
                case "6":
                    Console.Clear();

                    break;
                case "7":
                    Console.Clear();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Et syöttänyt oikeaa numeroa");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

            goto ALKU;
        }

        static void ohjelma1(int luku1, int luku2)
        {
        ALKU1:
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

        static void ohjelma2(int luku1, int luku2, int luku3)
        {
        ALKU2:
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
                   Console.WriteLine("Luvut ovat samanarvoisia");
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

        public static void ohjelma3()
        {
        ALKU3:
            Console.Clear();
            Console.WriteLine("Anna numero 0 ja 9 väliltä, jotta voin muuttaa sen sanaksi");

            string nimi = Console.ReadLine();
            switch (nimi)
            {

                case "0":
                    Console.WriteLine("Nolla");
                    break;
                case "1":
                    Console.WriteLine("Yksi");
                    break;
                case "2":
                    Console.WriteLine("Kaksi");
                    break;
                case "3":
                    Console.WriteLine("Kolme");
                    break;
                case "4":
                    Console.WriteLine("Neljä");
                    break;
                case "5":
                    Console.WriteLine("Viisi");
                    break;
                case "6":
                    Console.WriteLine("Kuusi");
                    break;
                case "7":
                    Console.WriteLine("Seitsemän");
                    break;
                case "8":
                    Console.WriteLine("Kahdeksan");
                    break;
                case "9":
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Annoit väärän luvun, yritä uudelleen painamalla ENTER");
                    Console.ReadLine();
                    Console.Clear();
                    goto ALKU3;
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();

        }
        static void ohjelma4(int luku1, int luku2, int luku3, int luku4, int luku5)
        {
        ALKU4:
            Console.WriteLine("Syötä viisi kokonaislukua, jotta voin etsiä niistä suurimman");

            try
            {
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
                luku3 = int.Parse(Console.ReadLine());
                luku4 = int.Parse(Console.ReadLine());
                luku5 = int.Parse(Console.ReadLine());
            } catch
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
                            Console.WriteLine("Luvut ovat samanarvoisia");
                        }
                    }
                }
            } else
            {
                Console.WriteLine(suurin + " on suurin");
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();


        }
    }
}   

