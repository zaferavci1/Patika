using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogreci1=new Ogrenci();
            ogreci1.Isim="Yasemin";
            ogreci1.Soyisim="Yilmaz";
            ogreci1.Sinif=12;
            ogreci1.OgrenciNo=1290;
            ogreci1.OgrenciBilgileriniGetir();
            ogreci1.sinifAtlat();
            ogreci1.OgrenciBilgileriniGetir();

            System.Console.WriteLine("***ogrenci2*****");
            Ogrenci ogrenci2=new Ogrenci("Engin Deniz","Alpman",1291,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            get{ return isim;} 
            set{ isim = value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get { return sinif;}
            set { 
                    if (value<1)
                    {
                    System.Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif=1;
                    }
                    else
                    {
                        sinif = value;
                    }
                }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.OgrenciNo = ogrenciNo;
            this.Sinif = sinif;
        }
        public Ogrenci(){}
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Ogrenci Bilgileri ----***");
            Console.WriteLine("Ogremci adi      :{0}",this.Isim);
            Console.WriteLine("Ogremci soyadı      :{0}",this.Soyisim);
            Console.WriteLine("Ogremci no      :{0}",this.OgrenciNo);
            Console.WriteLine("Ogremci sınıfı      :{0}",this.Sinif);
        }
        public void sinifAtlat(){
            this.Sinif+=1;
            }
        public void sinifDusur(){
            this.Sinif-=1;
            }
    }
}  