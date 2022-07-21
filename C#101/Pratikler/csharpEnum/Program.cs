using System;

namespace csharpEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cuma);
            Console.WriteLine(((int)Gunler.Cumartesi));
            int sicaklik=32;
            if (sicaklik<=((int)HavaSicakligi.normal))
            {
                System.Console.WriteLine("disariya cıkmak icin havanin biraz daha ısınmasının bekleylim");
            }
            else if(sicaklik>=((int)HavaSicakligi.sicak))
            {
                System.Console.WriteLine("Disariya cikmak  icin cok sicak bir gun");
            }
            else if (sicaklik>=((int)HavaSicakligi.normal) && sicaklik<=((int)HavaSicakligi.cokSicak))
            {
                System.Console.WriteLine("HAdi disariya cikallim");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaSicakligi
    {
        Soguk=5,
        normal=20,
        sicak=25,
        cokSicak=30

    }
}