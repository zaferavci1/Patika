using System;

namespace hazirMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hosgeldiniz.";
            string degisken2="dersimiz CSharp,.";

            //Length
            System.Console.WriteLine(degisken.Length);

            //ToUpper ToLower 
            System.Console.WriteLine(degisken.ToUpper());
            System.Console.WriteLine(degisken.ToLower());

            //Concat
            System.Console.WriteLine(String.Concat(degisken,"Merhaba"));

            //Compare CompareTo

            System.Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            System.Console.WriteLine(string.Compare(degisken,degisken2,true));
            System.Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains degisken birin içinde degiske 2 var mı
            System.Console.WriteLine(degisken.Contains(degisken2));
            System.Console.WriteLine(degisken.EndsWith("Hosgeldiniz."));
            System.Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            System.Console.WriteLine(degisken.IndexOf("CS"));
            System.Console.WriteLine(degisken.IndexOf("3"));
            System.Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            System.Console.WriteLine(degisken.Insert(0,"Merhaba"));


            //PadLeft  PadRight
            System.Console.WriteLine(degisken+degisken2.PadLeft(30));
            System.Console.WriteLine(degisken+degisken2.PadLeft(30,'z'));
            System.Console.WriteLine(degisken.PadRight(50,'2')+degisken2.PadRight(50));

            //Remove
            System.Console.WriteLine(degisken.Remove(10));
            System.Console.WriteLine(degisken.Remove(0,degisken.Length));

            //Replace
            System.Console.WriteLine(degisken.Replace("CSharp","C#"));
            System.Console.WriteLine(degisken.Replace(" ","-"));

            //Split
            System.Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            System.Console.WriteLine(degisken.Substring(4));//4 ten sona kadar 
            System.Console.WriteLine(degisken.Substring(4,6)); //4 ten 6 ya kadar
        }
    }
}