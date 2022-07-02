using System;

namespace dongulerWhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp
            //console a yazan program
            System.Console.Write("lütfen bir sayi giriniz");
            int sayi=int.Parse(Console.ReadLine()),sayac=1,toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            System.Console.WriteLine("Ortalama: "+toplam/sayi);

            //a'dan z'ye kadar tüm harfleri console a yazdır
            char character='a';
            while (character<='z')
            {
                System.Console.Write(character);
                character++;
            }

            System.Console.WriteLine("************** Foreach ************");
            string[] arabalar={"bmw","ford","toyota","jaguar"};
            foreach (var item in arabalar)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}