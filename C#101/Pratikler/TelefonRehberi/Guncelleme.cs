namespace proje1
{
    class Guncelleme
    {
        public void kisiGuncelleme(List<Kisi> list){
            Tekrar:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string value=Console.ReadLine();//serkan
            string TempIsim="";
            string TempSoyIsim = "";
            string TempTelefonNumarasi = "";
            
            Listele kisiGuncelle=new Listele();
            if (list.Exists(x => x.Name.Contains(value))){//serkanı bul
                kisiGuncelle.kisiListele(list.Find(x => x.Name == value));
                Console.WriteLine("Yeni ismi giriniz: ");
                TempIsim =Console.ReadLine();//serkankanki
                list.Find(x => x.Name == value).Name=TempIsim;//serkankanki
                Console.WriteLine("Yeni soyismi giriniz: ");
                TempSoyIsim =Console.ReadLine();
                list.Find(x => x.Name == TempIsim).SurName=TempSoyIsim;
                Console.WriteLine("Yeni telefon no giriniz: ");
                TempTelefonNumarasi =Console.ReadLine();
                list.Find(x => x.Name == TempIsim).Telephone=TempTelefonNumarasi;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için :             : (1) \n* Yeniden denemek için              : (2)");
                int secim=Convert.ToInt32(Console.ReadLine());
                if (secim==2)
                {
                    goto Tekrar;
                }
                if (secim==1)
                {
                    sonlandi();
                }
            }
        }
        public int sonlandi(){
            return 1;
        }
    }
}