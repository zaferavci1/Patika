using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;
            //expression neyi kontrol etmek isitoyrum
            switch (month)
            {
                case 1:
                System.Console.WriteLine("Ocak ayindayiz.");
                break;
                case 2:
                System.Console.WriteLine("Şubat Ayındayız");
                break;
                case 3:
                System.Console.WriteLine("MArt ayindayiz");
                break;
                case 6:
                System.Console.WriteLine("Haziran ayindayiz");
                break;
                case 5:
                System.Console.WriteLine("Mayis AYindayiz");
                break;
                case 7:
                System.Console.WriteLine("Temmuz ayindayiz");
                break;
                default:
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış mevsimindeyiz");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar mevsimindeyiz");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz mevsimindeyiz");
                    break;
                default:
                break;
            }
        }
    }
}