using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="9999";
            bool sonuc=int.TryParse(sayi,out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı Çevirme");
                System.Console.WriteLine(outSayi);
            }
            else
                System.Console.WriteLine("Başarısız");

            Metotlar ornek=new Metotlar();
            ornek.Topla(2,3,out int toplamSonuc); 
            System.Console.WriteLine(toplamSonuc);

            //metot aşırı yükleme - overloading
            int ifade=999;
            ornek.ekranaYazdir(Convert.ToString(ifade));
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam){
            toplam=a+b;
        }
        public void ekranaYazdir(string veri){
            System.Console.WriteLine("string metot"+veri);
        }
        public void ekranaYazdir(int sayi){
            System.Console.WriteLine("int metot"+sayi);
        }

    }
}
