using System;

namespace dizilerMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayilar={23,12,45,12,56,23,78,68,45};
            System.Console.WriteLine("**********Sırasız Dizi**********");
            foreach (var sayi in sayilar)
            {
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("**********Sıralı Dizi**********");
            Array.Sort(sayilar);
            foreach (var sayi in sayilar)
            {
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("**********Array Clear Dizi**********");
            //clear
            // sayilar dizisinin elemanlarını kullanarak 2 den başlayarak 2 elemanını sıfırlar
            Array.Clear(sayilar,2,2);
            foreach (var sayi in sayilar)
            {
                System.Console.WriteLine(sayi);
            }
            //Reverse 
            Array.Reverse(sayilar);
            System.Console.WriteLine("**********Array Reverse Dizi**********");
            foreach (var sayi in sayilar)
            {
                System.Console.WriteLine(sayi);
            }
            //indexOf
            System.Console.WriteLine("**********Array IndexOf Dizi**********");
            System.Console.WriteLine(Array.IndexOf(sayilar,45));
            //resize
            System.Console.WriteLine("**********Array Resize Dizi**********");
            Array.Resize<int>(ref sayilar, 9);
            sayilar[4]=99;
            foreach (var sayi in sayilar)
            {
                System.Console.WriteLine(sayi);
            }

            
        }
    }
}