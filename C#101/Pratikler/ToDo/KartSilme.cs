using ToDO;

namespace ToDo
{
    class KartSilme
    {
        public void kartSil(List<Kart> karts){
            Console.WriteLine("Silinecek kisinin kart bilgisini giriniz: ");
            string ad= Console.ReadLine();
            if (karts.Remove(karts.Find(x => x.KartSahibi ==ad)))
            {
                Console.WriteLine(ad+" Kişi silindi ");
            }
        }
    }
}