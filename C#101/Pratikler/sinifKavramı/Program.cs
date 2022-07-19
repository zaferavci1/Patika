using System;

namespace sinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz dizimi
            // class sinifKavrami
            // {
            //     [Erişim belirleyici] [veri tipi] özellikAdi;
            //     [Erişim belirleyici] [geri dönüş tipi] MethodAccessException adi([PArametre listesi])
            //     {
            //         MethodAccessException komutları
            //     }
            // }

            //Erişim belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1=new Calisan();
            calisan1.Ad="Zafer";
            calisan1.Soyad="Avcı";
            calisan1.No=123589766;
            calisan1.Departman="Müdür";

            calisan1.CalisanBilgiler();

            Calisan calisan2=new Calisan();

            calisan2.Ad="Boran";
            calisan2.Soyad="Avcı";
            calisan2.No=15696878;
            calisan2.Departman="Müğdür";
            calisan2.CalisanBilgiler();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgiler(){
            Console.WriteLine("Çalışan ADı: {0}", Ad);
            System.Console.WriteLine("Çalışan Sayısı: {0}",Soyad);
            System.Console.WriteLine("Çalışan Numarası: {0}",No);
            System.Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}