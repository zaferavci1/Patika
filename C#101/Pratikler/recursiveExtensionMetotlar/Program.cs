using System;

namespace recursiveExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekusive - öz Yinelemeli 
            //3^4
            int result=1;
           for (int i = 1; i <5 ; i++)
           {
            result*=3;
           } 
           System.Console.WriteLine(result);
           Islemler instence=new Islemler();
           System.Console.WriteLine(instence.Expo(3,4));

           //Extension Metotlar
           string ifade="Zikriye Ürkmez";
           bool sonuc=ifade.CheckSpaces();
           System.Console.WriteLine(sonuc);
           if (sonuc)
           {
                System.Console.WriteLine(ifade.REmoveWhithSpaces());
           }
           System.Console.WriteLine(ifade.MakeUpperCAse());
           System.Console.WriteLine(ifade.ToLower());

           int[] dizi={9,7,5,2,3,2,78};
           dizi.SortArray();
           dizi.EkranaYazdir();
           int sayi=5;
           System.Console.WriteLine(sayi.IsEverNumber());
           System.Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    class Islemler
    {
        public int Expo( int sayi,int üs){
            if (üs==1)
            {
                return sayi;
            }
            return Expo(sayi,üs-1)*sayi;
        }
    }
    public static class Extension{

        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }
        public static string REmoveWhithSpaces(this string param){
            string[] dizi=param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string MakeUpperCAse(this string param){
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
        public static int[] SortArray (this int[] param){
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param){
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }
        public static bool IsEverNumber(this int param){
            return param%2==0;
        }
        public static string GetFirstCharacter(this string abc){
            return abc.Substring(0,1);
        }
    }
}