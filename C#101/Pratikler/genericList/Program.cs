using System;
using System.Collections.Generic;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
               //List<> class
               //System.Collections.Generic
               // T --> object türündedir.

            List<int> sayiListesi=new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(15);
            sayiListesi.Add(68);
            sayiListesi.Add(89);

            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Sarı");
            renkListesi.Add("Siyah");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("Yeşil");
            
            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            //ForEach ve List ile elamanlara erişim 
            System.Console.WriteLine("*****ForEach ve List ile elamanlara erişim ");
            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }
            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            renkListesi.ForEach(x=> System.Console.WriteLine(x));

            //Lİsteden eleman çıkarma
            sayiListesi.Remove(23);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(2);

            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            renkListesi.ForEach(x=> System.Console.WriteLine(x));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                System.Console.WriteLine("10 liste içerisinde kullanılıyor");
            }

            //Eleman ile indekse eişim
            System.Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            //Diziyi Listeye çevirme
            string[] hayvanlar={"KEdi","Köpek","kus"};
            List<string> hayvanListesi=new List<string>(hayvanlar);

            //Lİsteyi nasıl temizleriz?
            hayvanListesi.Clear();


            //Lİste içerisinde nesne tutmak
            List<kullanicilar> kullaniciListesi=new List<kullanicilar>();
            kullanicilar kullanici1=new kullanicilar();
            kullanici1.Isim="Zafer";
            kullanici1.Soyisim="Avcı";
            kullanici1.Yas=20;

            kullanicilar kullanici2=new kullanicilar();
            kullanici2.Isim="Boran";
            kullanici2.Soyisim="Serkan";
            kullanici2.Yas=23;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<kullanicilar> yeniListe=new List<kullanicilar>();
            yeniListe.Add(new kullanicilar(){
                Isim="Memet",
                Soyisim="Teper",
                Yas=22
            });

            foreach (var item in kullaniciListesi)
            {
                System.Console.WriteLine("Kullancıı adı: "+item.Isim);
                System.Console.WriteLine("Kullanıcı Soyisim: "+item.Soyisim);
                System.Console.WriteLine("Kullanıcı Yas: "+item.Yas);
            }
            yeniListe.Clear();


        }
    }
    public class kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get=>isim; set=> isim=value; }
        public string Soyisim { get=>soyisim; set=> soyisim=value; }
        public int Yas { get=>yas; set=> yas=value; }

    }
}