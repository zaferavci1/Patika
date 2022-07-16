using System;
using System.Collections;

namespace koleksiyonlarSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal=new ArrayList(); 
            ArrayList noAsal=new ArrayList();
            int a=0,b=0,c=0;
           for (int i = 0; i < 20; i++)
           {
                Console.Write("Pozitif Sayi Giriniz: ");
                c=int.Parse(Console.ReadLine());
                if (c>0)
                {
                    a=c;
                    for (int j = 2; j < a; j++)
                    {
                        if (a % j == 0){
                            b++;
                        }
                    }
                    if (b!=0)
                    {
                        asal.Add(a);
                        System.Console.WriteLine("eklendi asal");
                    }
                    else
                    {
                        noAsal.Add(a);  
                        System.Console.WriteLine("eklendi asal değil");      
                    }   
                }
                else
                {
                    System.Console.WriteLine("Giridiğiniz sayi negatif");
                }
           }
           noAsal.Sort();
           asal.Sort();
           for (int i = asal.Count; i > 0; i--)
           {
                Console.Write("Asal: "+asal[i-1]+"\n");
           }
           for (int i = noAsal.Count; i > 0; i--)
           {
                Console.WriteLine("Asal Değil: "+noAsal[i-1]+"\n");
           }

           Console.WriteLine(asal.Count);
           Console.WriteLine(noAsal.Count);

            int asalToplam=0,noAsalToplam=0;
           foreach (var item in asal)
           {
                asalToplam+=Convert.ToInt32(item);
           }
           foreach (var item in noAsal)
           {
                noAsalToplam+=Convert.ToInt32(item);
           }
           System.Console.WriteLine("ASal ortalama: "+asalToplam/(asal.Count));
           System.Console.WriteLine("ASal ortalama: "+noAsalToplam/(noAsal.Count));

        }
    }
}