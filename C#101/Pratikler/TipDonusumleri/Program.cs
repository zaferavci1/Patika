using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args){
    
    
        //Implicit Conversion (bilinçsiz Dönüşüm)
        System.Console.WriteLine("**********Implicit Conversion (bilinçsiz Dönüşüm)***************");
        byte a=5;
        sbyte b=30;
        short c=10;
        int d=a+b+c;
        System.Console.WriteLine(  "d: "+d);
        long h=d;
        System.Console.WriteLine( "h: "+h);
        float i=h;
        System.Console.WriteLine("i: "+h);
        string e="zafer";
        char f='a';
        object g=e+f+d;
        System.Console.WriteLine("g: "+g);


        //Explicit Conversion (bilinçli Dönüşüm)

        System.Console.WriteLine("----Explicit Conversion (bilinçli Dönüşüm)------");
        int x=4;
        byte y=(byte)x;//sağındaki veriyi parantez içerisindeki veriye dönüştürecek
        System.Console.WriteLine("y: "+y);
        int z=100;
        byte t=(byte)z;
        System.Console.WriteLine("t: "+t);

        float w=10.3f;
        byte v=(byte)w;
        System.Console.WriteLine("v: "+v);

        // ** ToString Methodu******
        System.Console.WriteLine("*****ToString Methodu******");
        int xx=6;
        string yy=xx.ToString();
        System.Console.WriteLine("yy: "+yy);
        string zz=12.5f.ToString();
        System.Console.WriteLine("zz: "+zz);


        //System.Convert
        System.Console.WriteLine("*********System.Convert***** sınıfı");
        string sayi1="10",sayi2="20";
        int s1,s2,toplam;

        s1=Convert.ToInt32(sayi1);
        s2=Convert.ToInt32(sayi2);
        toplam=s1+s2;
        System.Console.WriteLine("Toplam: "+toplam);

        //Parse
        System.Console.WriteLine("*****Parse*****");
        ParseMethod();
        }
        public static void ParseMethod(){
            
            string metin1="10";
            string metin2="10,25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);
            //Parse string ifadeleri değiştirmek için kullanılır bu yuzden parse hep string veri tipi alır
            System.Console.WriteLine("rakam1: "+rakam1);
            System.Console.WriteLine("double1: "+double1);
        


        }
    }
}
   










