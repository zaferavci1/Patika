using System;
using System.Collections.Generic;

namespace dictinory
{
    class Program
    {
        static void Main(string[] args){

            //System.Collections.Generic
            Dictionary<int,string> kullanıcılar= new Dictionary<int,string>();
            kullanıcılar.Add(10,"Ayse Yilmaz");
            kullanıcılar.Add(12,"Ahmet Zafer");
            kullanıcılar.Add(18,"Özcan coşar");
            kullanıcılar.Add(20,"Boran Avcı");

            //dizinin elemanlarına erisim
            System.Console.WriteLine("*****Dizinin elemanlarına erişim----");
            System.Console.WriteLine(kullanıcılar[10]);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            //Count
            System.Console.WriteLine("***Count----");
            System.Console.WriteLine(kullanıcılar.Count);

            //Contains
            System.Console.WriteLine("****Contains---");
            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Boran Avcı"));
            
            System.Console.WriteLine("****Remove---");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item.Value);
            }

            //Keys
            System.Console.WriteLine("****Keys---");
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }

            //Value
            System.Console.WriteLine("****Value---");
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}