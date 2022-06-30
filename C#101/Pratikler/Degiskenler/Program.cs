using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args){
            int deger;
            deger=2;
            string ad=null;
            string Ad=" ";
            byte B=6;  //0 İLE 255 arası deger alabilir
            sbyte c=3; //-128 ile 127 arasında değer alabilir
            short s=5; //2 byte yer kaplar  -32768 den + 32768 e kadar yer kaplar
            ushort us=2; //2 byte yer kaplar 0 ile 65365 arasında değerlerden bir tanesini alabilir
            Int16 i16=9; //2byte yer kaplar
            int i=2; // 4 byte yer kaplar -2147483648 ile   +2147483648
            Int32 i32=4;  // 4 byte yer kaplar
            Int64 i64=24;  // 8 byte yer kaplar
            uint ui=6; //4 byte yer kaplar
            long l=789; //8 byte yer kaplar
            ulong ul=789; //8 byte yer kaplar

            float f=23; //4 byte yer kaplar ondalıklı sayılar
            double d= 345; // 8 byte yer kaplar
            decimal k= 3453; //16 byte yer kaplar
            char e= '9'; //tek karakter için bellekte 2 byte yer kaplar
            

            bool r=true;
            bool t=false; 
            DateTime dt=DateTime.Now;
            object o1='x';  //object her türden veriyi alıyor
            object o2=4;
            string str3=string.Empty; //null veya "" boş değer için kullanabilirsin
            string str="s"; //sınırsız yer kaplar
            string str4="a"; //sınırsız yer kaplar
            string tamisim=str +" "+ str4; //sınırsız yer kaplar
            int v=4;
            int y=5;
            int carp= v*y;
            bool d4=10>2;

            //Değişken dönüşümlerri
            string str20="20";
            int int20=20;
            string yenideger=str20+int20.ToString();

            Console.WriteLine(yenideger);
            int tamdeger=int20+ Convert.ToInt32(str20);
            Console.WriteLine(tamdeger);
            int tam2=int20+ int.Parse(str20); //parse sa int dönüşümlerde kullanılıyo çıktısı 40
            string dtime=DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            Console.WriteLine(dtime);
        }
    }
}