using System;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
               Console.WriteLine("İşlem Tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
               // int a=int.Parse("test");
                int b=int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("VEri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük yada çok büyük değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally{
                System.Console.WriteLine("İşlem başarıyla tamamalandı");
            }
            
  
        }
    }
}
