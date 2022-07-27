using System;
using ToDO;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            string baslik,icerik,kartsahibi,buyukluk=null;
            List<Kart> TODO = new List<Kart>();
            List<Kart> INPROGRESS = new List<Kart>();
            List<Kart> DONE = new List<Kart>();
            KartEkle todoo=new KartEkle();
            KartEkle inprogres=new KartEkle();
            KartEkle donee=new KartEkle();
            todoo.ekleme(TODO);
            KartListele kartListele=new KartListele();
            KartSilme kartSilme= new KartSilme();
            
            Console.ReadLine();
            int a,b;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************");
                Console.WriteLine("(1) Board Listelemek \n (2) Board'a Kart Eklemek \n (3) Board'dan Kart Silmek\n (4) Kart Taşımak");
                a=Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        kartListele.Listele(TODO);
                    break;
                    case 2:
                        Console.WriteLine("Başlik Giriniz: ");
                        baslik=Console.ReadLine();

                        Console.WriteLine("İçerik Giriniz: ");
                        icerik=Console.ReadLine();

                        Console.WriteLine("Büyüklük Giriniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
                        b=Convert.ToInt32(Console.ReadLine());
                        if (b==1)
                            buyukluk=Convert.ToString(Buyukluk.XS);

                        if (b==2)
                            buyukluk=Convert.ToString(Buyukluk.S);

                        if (b==3)
                            buyukluk=Convert.ToString(Buyukluk.M);

                        if (b==4)
                            buyukluk=Convert.ToString(Buyukluk.L);

                        if (b==5)
                            buyukluk=Convert.ToString(Buyukluk.XL);

                        Console.WriteLine("Başlik Giriniz: ");
                        baslik=Console.ReadLine();

                        Console.WriteLine("Kart Kişisini Giriniz: ");
                        kartsahibi=Console.ReadLine();

                        TODO.Add(new Kart(baslik,icerik,kartsahibi,buyukluk));
                    break;
                    case 3:
                        kartListele.Listele(TODO);
                        kartSilme.kartSil(TODO);
                    break;
                }
            } while (a!=4);
        }
    }
}