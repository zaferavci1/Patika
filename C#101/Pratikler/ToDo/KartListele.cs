using ToDO;

namespace ToDo
{
    class KartListele
    {
        public void Listele(List<Kart> kartList){
            foreach (var item in kartList)
            {
                Console.WriteLine(item.Baslik);
                Console.WriteLine(item.Buyukluk);
                Console.WriteLine(item.Icerik);
                Console.WriteLine("kart sahibi: "+item.KartSahibi);
            }
        }        
    }
}