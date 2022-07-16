using System;
using System.Collections;

namespace koleksiyonlarSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste=new ArrayList();
            int a=0,ilkUc=0,sonUc=0;
            for (int i = 0; i < 20; i++)
            {
                System.Console.Write("Sayi giriniz: ");
                a=int.Parse(Console.ReadLine());
                liste.Add(a);
            }
            liste.Sort();
            for (int i = 0; i < 3; i++)
            {
                ilkUc+=Convert.ToInt32(liste[i]);
            }
            for (int i = liste.Count; i < (liste.Count-3); i--)
            {
                sonUc+=Convert.ToInt32(liste[i-1]);
            }
            Console.WriteLine( "ilk uc= "+ ilkUc/3 );
            Console.WriteLine( "son uc= "+ sonUc/3 );
            Console.WriteLine("ortalama toplam: "+(ilkUc/3)+(sonUc/3));
        }
    }
}