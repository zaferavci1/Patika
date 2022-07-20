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
            Console.WriteLine("--****---** Calisan 1*/-**---**--");
            Calisan calisan1=new Calisan("zafer","avcı","müdür",12893456);
            calisan1.CalisanBilgiler();

            Console.WriteLine("--****---** Calisan 2*/-**---**--");

            Calisan calisan2=new Calisan();
            calisan2.Ad="Boran";
            calisan2.Soyad="Avcı";
            calisan2.No=15696878;
            calisan2.Departman="Müğdür";
            calisan2.CalisanBilgiler();

            
            Console.WriteLine("--****---** Calisan 3*/-**---**--");

            Calisan calisan3=new Calisan("zikriye ","ürkmez");
            calisan3.CalisanBilgiler();

        }
    }




class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,string departman,int no)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public Calisan (){}

        public void CalisanBilgiler(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            System.Console.WriteLine("Çalışan Sayısı: {0}",Soyad);
            System.Console.WriteLine("Çalışan Numarası: {0}",No);
            System.Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}
