namespace proje1
{
    class KisiBulma
    {   
        public void kisiBul(List<Kisi> list){
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n***************\n\n");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)\n Telefon numarasına göre arama yapmak için: (2)");
            int option=0;          
            option=Convert.ToInt32(Console.ReadLine());
            Listele kisiList=new Listele();
             string isim=null,telNo=null;
            // switch (option)
            // {
            //     case 1:
            //         Console.WriteLine("İsim veya soyisim giriniz: ");
            //         isim =Console.ReadLine();
            //         Console.WriteLine("isism: -**-"+ list.Find(x => x.Name == isim));
            //         kisiList.kisiListele(list.Find(x => x.Name == isim));
            //     break;
            //     case 2:
            //         Console.WriteLine("Telefon numarası giriniz: ");
            //         telNo=Console.ReadLine();
            //         kisiList.kisiListele(list.Find(x => x.Telephone == telNo));
            //     break;
            // }
            if (option == 1)
            {
                Console.WriteLine("İsim veya soyisim giriniz: ");
                isim =Console.ReadLine();
                kisiList.kisiListele(list.Find(x => x.Name == isim));
            }
            if (option == 2)
            {
                Console.WriteLine("Telefon numarası giriniz: ");
                telNo=Console.ReadLine();
                kisiList.kisiListele(list.Find(x => x.Telephone == telNo));
            }
        }
    }
}