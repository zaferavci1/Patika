using System;

namespace dongulerForLoop
{
    class Program
{           
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            System.Console.Write("Lütfen bir sayi giriniz");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                //komutlar
                if (i%2==1)
                {
                    System.Console.WriteLine("tek sayi: "+i);
                }
            }
            //1 ile 100 arasında tek ve çift sayıları kendi içersiisnde topla ekrana yazdir
            int tekToplam=0,ciftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam+=i; //tek toplam
                }
                else
                    ciftToplam+=i; //cift toplam
                
            }
            System.Console.WriteLine(" tek toplam: " + tekToplam);
            System.Console.WriteLine("Çift toplam: "+ ciftToplam);
            // break,continue
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                    System.Console.WriteLine(i);
            }
        }
    }
}