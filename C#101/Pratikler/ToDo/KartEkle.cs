using ToDO;

namespace ToDo
{
    class KartEkle
    {
        public void ekleme(List<Kart> karts){
            karts.Add(new Kart("zafer","avcı","Zafer",Convert.ToString(Buyukluk.XL)));
            karts.Add(new Kart("serkan","yilmaz","Serkan",Convert.ToString(Buyukluk.L)));
            karts.Add(new Kart("boran","avcı","Boran",Convert.ToString(Buyukluk.XS)));
        }
    }
}