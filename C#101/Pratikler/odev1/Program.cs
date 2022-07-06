using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Odev ornek1=new Odev();
            
                ornek1.kelimeHarf();
            // System.Console.Write("cift olan icin pozitif bir sayi giriniz");
            // int a=Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("esit tam icin pozitif iki sayi giriniz");
            // int b=Convert.ToInt32(Console.ReadLine());
            // int c=Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("kelime gir icin pozitif bir sayi giriniz");
            // int d=Convert.ToInt32(Console.ReadLine());
            // if (a>0 && b>0 && c>0)
            // {
            //     ornek1.ciftOlan(a);
            //     ornek1.esitTam(b,c);
            //     ornek1.kelimeGir(d);
            // }
        }
    }
    class Odev
    {
        public void ciftOlan(int n)
        {
            int[] sayi=new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(i+". saiyiyi giriniz");
                sayi[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (sayi[i]%2==0)
                {
                    System.Console.WriteLine(sayi[i]+"Sayisi çifttir ");
                }
            }
        }
        public void esitTam(int a,int b)
        {
            int[] abc=new int[a];
            for (int i = 0; i < a; i++)
            {
                System.Console.WriteLine(i+". saiyiyi giriniz");
                abc[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                if (abc[i]==b || abc[i]%b==0)
                {
                    System.Console.WriteLine(abc[i]+" sayisi "+b+" sayisina tam bölünür.");
                }
                else
                System.Console.WriteLine("hiçbir sayi "+b+" sayisina bölünmüyor ve eşit değil");
            }
        }
        public void kelimeGir(int n)
        {
            string[] abc=new string[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(i+". kelimeyi giriniz: ");
                abc[i]=Console.ReadLine();
            }
            for (int i = n-1; i >= 0; i--)
            {
                System.Console.WriteLine(abc[i]);
            }
        }
        public void kelimeHarf()
        {
            System.Console.WriteLine(" Bir cümle giriniz ");
             string a=Console.ReadLine();
            string[] abc= a.Split(" "); 
            int c=0,b=a.Length;
            System.Console.WriteLine("kelime sayisi "+abc.Length); 
            for (int i = 0; i < b; i++)
            {
                if (a[i]!=' ')
                {
                    c++;
                }
            }
            System.Console.WriteLine("Harf sayisi "+c);
        }
        
    }
}