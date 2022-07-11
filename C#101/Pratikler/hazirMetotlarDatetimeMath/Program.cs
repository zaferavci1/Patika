using System;

namespace hazirMetotlarDatetimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now);//Günün tarihi
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(40));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(2));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(30));

            //Datetime Format
            
            System.Console.WriteLine(DateTime.Now.ToString("dd"));//24
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday
            
            System.Console.WriteLine(DateTime.Now.ToString("MM"));//04
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));//April
            
            System.Console.WriteLine(DateTime.Now.ToString("yy"));//22
            System.Console.WriteLine(DateTime.Now.ToString("yyy"));//2022

            System.Console.WriteLine("*******Math Kütüphanesi---------");
            //Math Kütüphanesi
            System.Console.WriteLine(Math.Abs(-25));//25 mutlak
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));

            System.Console.WriteLine(Math.Ceiling(22.3));//23 her zaman yukarıya yuvarlar
            System.Console.WriteLine(Math.Round(22.3));//22 0.5 değerine göre yuvarlama yapar
            System.Console.WriteLine(Math.Round(22.7));//23
            System.Console.WriteLine(Math.Floor(22.7));//22 her zaman aşşağıya yuvarlar

            System.Console.WriteLine(Math.Min(2,6));
            System.Console.WriteLine(Math.Max(2,6));

            System.Console.WriteLine(Math.Pow(3,4));//3^4 81
            System.Console.WriteLine(Math.Sqrt(9));//karekök alır 3
            System.Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logu
            System.Console.WriteLine(Math.Exp(3));// e üzeri 3 ü veriri
            System.Console.WriteLine(Math.Log10(10));
            
            
        }
    }
}