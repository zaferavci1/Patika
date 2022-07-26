namespace proje1
{
    class Listele
    {
        public void liste(List<Kisi> list){
            Console.WriteLine("Telefon Rehberi \n **************************************");
            foreach (var item in list)
            {
                Console.WriteLine("İsim: "+item.Name);
                Console.WriteLine("Soyisim: "+item.SurName);
                Console.WriteLine("Telefon: "+item.Telephone);
                Console.WriteLine("************");
            }
        }

        public void kisiListele(Kisi kisi){
            
            Console.WriteLine("İsim: "+kisi.Name);
            Console.WriteLine("Soyisim: "+kisi.SurName);
            Console.WriteLine("Telefon: "+kisi.Telephone);
            Console.WriteLine("************");
        }
    }
}