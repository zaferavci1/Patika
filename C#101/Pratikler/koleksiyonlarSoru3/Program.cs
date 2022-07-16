using System;
using System.Collections;

namespace koleksiyonlarSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle=Console.ReadLine();
            int a=0;
            char[] sesliHarf={'a','e','i','ı','o','ö','u','ü'};
            ArrayList sesliList=new ArrayList();
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < cumle.Length; i++)
                {
                    if (cumle[i]==sesliHarf[j])
                    {
                        sesliList.Add(cumle[i]);
                    }
                }
                
            }
            foreach(var item in sesliList){
                System.Console.WriteLine(item);
            }
        }
    }
}