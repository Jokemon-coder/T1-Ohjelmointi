using System;

namespace Harjoituksia1
{
    class Program
    {
        
        static void Main(string[] args)
        { 

            Console.WriteLine("Harjoituksia 1");
            Console.WriteLine("Valitse: ");
            Console.WriteLine("Tulostus1 painamalla 1");
            Console.WriteLine("Tulostus2 painamalla 2");
            Console.WriteLine("Tulostus3 painamalla 3");
            Console.WriteLine("Tulostus4 painamalla 4");
            Console.WriteLine("Tulostus5 painamalla 5");
            Console.WriteLine("Tulostus6 painamalla 6");
            Console.WriteLine("Tulostus7 painamalla 7");
            Console.WriteLine("Tulostus8 painamalla 8");
            Console.WriteLine("Tulostus9 painamalla 9");

            string tulostus = Console.ReadLine();
            switch (tulostus)
            {
                case "1":
                    tulostus1(10, 5);
                    break;
                case "2":
                    tulostus2(10, 5);
                    break;
                case "3":
                    tulostus3(10, 5);
                    break;
                case "4":
                    tulostus4(10, 5);
                    break;
                case "5":
                    tulostus5(10, 5);
                    break;
                case "6":
                    tulostus6(10, 5);
                    break;
                case "7":
                    tulostus7(10, 5);
                    break;
                case "8":
                    tulostus8(10, 5);
                    break;
                case "9":
                    tulostus9(10, 5);
                    break;
            }

        }


        public static void tulostus1(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y + 3");
                Console.WriteLine("x = " + (x = y + 3));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }

            
        }

        

        public static void tulostus2(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y - 2");
                Console.WriteLine("x = " + (x = y - 2));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus3(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y * 5");
                Console.WriteLine("x = " + (x = y * 5));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus4(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = x / y");
                Console.WriteLine("x = " + (x = x / y));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus5(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 24)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 24");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = x % y");
                Console.WriteLine("x = " + (x = x % y));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus6(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x += y");
                Console.WriteLine("x = " + (x += y));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }

        public static void tulostus7(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x -= y");
                Console.WriteLine("x = " + (x -= y));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus8(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x *= y * 5");
                Console.WriteLine("x = " + (x *= y * 5));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus9(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            y = int.Parse(Console.ReadLine());

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x /= y");
                Console.WriteLine("x = " + (x /= y));
            }
            else
            {
                Console.WriteLine("Annoit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }
    }
}

