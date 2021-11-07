﻿using System;

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
                    ohjelma1(0, 0);
                    break;
                case "2":
                    Console.Clear();
                    ohjelma2(0, 0, 0);
                    break;
                case "3":
                    Console.Clear();

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
            } catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                Console.WriteLine("---------------------------------");
                goto ALKU1;
            }
            
            if (luku1 > luku2)
            {
                Console.WriteLine(luku1 + " " + luku2);
            } else if (luku1 < luku2)
            {
                Console.WriteLine(luku2 + " " + luku1);
            } else
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
            }catch
            {
                Console.WriteLine("Syötä vain kokonaislukuja, kiitos");
                Console.WriteLine("---------------------------------");
                goto ALKU2;
            } 
            
            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                {
                    Console.WriteLine(luku1 + " on suurin");
                } 
            } if (luku2 > luku1)
            {
                if (luku2 > luku3)
                {
                    Console.WriteLine(luku2 + " on suurin");
                }
            } if (luku3 > luku1)
            {
                if (luku3 > luku2)
                {
                    Console.WriteLine(luku3 + " on suurin");
                }
            } else
            {
                Console.WriteLine("Luvut ovat yhtä suuria");
            }
            Console.WriteLine("Paina ENTER palataksesi valikkoon");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
