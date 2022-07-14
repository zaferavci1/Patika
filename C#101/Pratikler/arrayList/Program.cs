using System;
using System.Collections.Generic;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste=new ArrayList();
            // liste.Add("Ayse");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //içerisinde verilere erişme
            // System.Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //AddRange
            System.Console.WriteLine("*****AddRange****");

            //string[] renkler={"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar=new List<int>{1,4,6,8,3,2,5,12,67,45,90};

           // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Sort
            System.Console.WriteLine("****Sort----");
            liste.Sort();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Binary Search
            System.Console.WriteLine("*****Binary Search-----");
            System.Console.WriteLine(liste.BinarySearch(67));

            //REverse
            System.Console.WriteLine("*****Reverse-----");
            //ORtasından ayırma
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Clear
            System.Console.WriteLine("***Clear---");
            liste.Clear();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}