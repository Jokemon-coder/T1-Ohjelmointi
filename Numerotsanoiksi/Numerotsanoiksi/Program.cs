using System;

namespace Numerotsanoiksi
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Syötä numero, jonka haluat muuttaa sanoiksi");
                string numero = Console.ReadLine();
                numero = MuunnosMaara(double.Parse(numero));

                Console.WriteLine("Numero sanoissa on \n{0}", numero);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static String[] yhdetJaMuut = { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmene", "yksitoista", "kaksitoista", "kolmetoista",
        "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };

        private static String[] kymmenet = { "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
        public static String MuunnosMaara(double maara)
        {
            try
            {
                Int64 maara_int = (Int64)maara;

            }catch (Exception e)
            {

            }
            return "";
        }

        public static String Muunna(Int64 i)
        {
            if (i < 20)
            {
                return yhdetJaMuut[i];
            }
            if (i < 100)
            {
                return kymmenet[i / 10] + ((i % 10 > 0) ? " " + Muunna(i % 10) : "");
            }

            if (i > 1000)
            {

                return yhdetJaMuut[i / 100] + " sataa" + ((i % 100 > 0) ? " ja " + Muunna(i % 100) : "");
            
            }

            return i.ToString();






        }
        

        

    }
}
