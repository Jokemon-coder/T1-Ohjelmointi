using System;

namespace Harjoituksia1
{
    class Program
    {
        
        static void Main(string[] args)
        {

        ALKU:

            Console.WriteLine("Harjoituksia 1");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Valitse: ");
            Console.WriteLine("Tulostus 1 painamalla 1");
            Console.WriteLine("Tulostus 2 painamalla 2");
            Console.WriteLine("Tulostus 3 painamalla 3");
            Console.WriteLine("Tulostus 4 painamalla 4");
            Console.WriteLine("Tulostus 5 painamalla 5");
            Console.WriteLine("Tulostus 6 painamalla 6");
            Console.WriteLine("Tulostus 7 painamalla 7");
            Console.WriteLine("Tulostus 8 painamalla 8");
            Console.WriteLine("Tulostus 9 painamalla 9");

            string tulostus = Console.ReadLine();
            switch (tulostus)
            {
                
                case "1":
                    Console.Clear();
                    tulostus1(10, 5);                   
                    break;
                case "2":
                    Console.Clear();
                    tulostus2(10, 5);
                    break;
                case "3":
                    Console.Clear();
                    tulostus3(10, 5);
                    break;
                case "4":
                    Console.Clear();
                    tulostus4(10, 5);
                    break;
                case "5":
                    Console.Clear();
                    tulostus5(10, 5);
                    break;
                case "6":
                    Console.Clear();
                    tulostus6(10, 5);
                    break;
                case "7":
                    Console.Clear();
                    tulostus7(10, 5);
                    break;
                case "8":
                    Console.Clear();
                    tulostus8(10, 5);
                    break;
                case "9":
                    Console.Clear();
                    tulostus9(10, 5);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Et syöttänyt oikeaa numeroa");
                    Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
            goto ALKU;
        }

        public static void tulostus1(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            { 
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU1;
            } 


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch 
            { 
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;   
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y + 3");
                Console.WriteLine("x = " + (x = y + 3));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }

            
        }

        

        public static void tulostus2(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y - 2");
                Console.WriteLine("x = " + (x = y - 2));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus3(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = y * 5");
                Console.WriteLine("x = " + (x = y * 5));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus4(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = x / y");
                Console.WriteLine("x = " + (x = x / y));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus5(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 24)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 24");
                Console.WriteLine("y = 5");
                Console.WriteLine("x = x % y");
                Console.WriteLine("x = " + (x = x % y));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus6(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x += y");
                Console.WriteLine("x = " + (x += y));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }

        public static void tulostus7(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x -= y");
                Console.WriteLine("x = " + (x -= y));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus8(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x *= y * 5");
                Console.WriteLine("x = " + (x *= y * 5));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }


        }


        public static void tulostus9(int x, int y)
        {
        ALKU1:

            Console.WriteLine("Syötä X:n arvo:");

            try { x = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto ALKU1;
            }

            if (x == 10)
            {
                Console.WriteLine("Syötä Y:n arvo:");
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU1;
            }


        ALKU2:
            try { y = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen.");
                goto ALKU2;
            }

            if (y == 5)
            {
                Console.WriteLine("x = 10");
                Console.WriteLine("y = 5");
                Console.WriteLine("x /= y");
                Console.WriteLine("x = " + (x /= y));

                Console.WriteLine("Paina mitä vaan palataksesi valikkoon");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Syötit väärän arvon, yritä uudelleen");
                goto ALKU2;
            }

        }
    }
}

