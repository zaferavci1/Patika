using System;

namespace staticSınıfVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan1=new Calisan("Ayse","Yilmaz","ik");
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan2=new Calisan("zafer","avcı","pcmuh");
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            
            Console.WriteLine("Toplama islemi sonucu: {0}",Islemler.Topla(25,28));
            Console.WriteLine("Cikarma İSlemi sonucu: {0}",Islemler.Cikar(25,28));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }
        
        private string Isim,Soyisim,Departman;

        static Calisan(){
            calisanSayisi=0;
        }

        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2){
             return sayi1+sayi2;   
        }
        public static long Cikar(int sayi1,int sayi2){
             return sayi1-sayi2;   
        }
    }
}