using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler=new string[5];
            string[] hayvanlar={"kedi","kopek","kus","timsah"};

            int[] dizi;
            dizi=new int[5];
            //Dizilere değer atama ve erişim
            renkler[0]="mavi";
            dizi[3]=10;
            System.Console.WriteLine(hayvanlar[0]); 
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            //döngüler ile dizi kullanımı
            //klavyeden girilen n tane sayini ortalamasını hesaplayan program
            System.Console.Write("lütfen dizinin eleman sayısını giriniz:");
            int boyut=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                System.Console.WriteLine("Lütfen {0} sayiyi giriniz",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var item in sayiDizisi)
            {
                toplam+=item;
            }
            System.Console.WriteLine("ortlamam: "+toplam/boyut);

        }
    }
}