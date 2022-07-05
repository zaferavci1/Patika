using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_dönüştipi metot_adi(parametreListesiarguman)
            //{
                //komutlar
                //return;
            //}
            int a=2,b=3;
            int sonuc=Topla(a,b);
            System.Console.WriteLine(sonuc);
            metotlar ornek=new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            int sonuc2=ornek.ArttırVeTopla(ref a,ref b);
            //referansları yani bellekteki yerleri üzerinde değşim yazpıyor
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a));
            ornek.EkranaYazdir(Convert.ToString(b));

        }

        public static int Topla(int a, int b)
        {
            return (a+b);
        }
    }
    class metotlar
    {
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }
        public int ArttırVeTopla(ref int deger1,ref int deger2){
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}