using System;
using System.Collections;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> liste1=new List<Kisi>();
            Kisi zafer=new Kisi("Zafer","Avcı","05538826863");
            Kisi serkan=new Kisi("Serkan","Yilmaz","05538568863");
            Kisi boran=new Kisi("Boran ","Avcı","05330533114");
            liste1.Add(zafer);
            liste1.Add(serkan);
            liste1.Add(boran);
            
            // 
            // Console.WriteLine("Listele classi ile listelendi");
            // yeniList.liste(liste1);

            // Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            // string nameFind=Console.ReadLine();
            // liste1.Remove(liste1.Find(x => x.Name.Contains(nameFind)));
            // Console.WriteLine("silindikten sonra listelendi listelendi");
            // yeniList.liste(liste1);

            

            // Console.WriteLine("Kisi guncelleme.");
            // Guncelleme guncel1=new Guncelleme();
            // guncel1.kisiGuncelleme(liste1);

            string nameFind=null;

            int a;
            
                
                do
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                    Console.WriteLine("(1) Yeni numara kaydetmek. \n (2) Varolan numarayı silmek. ");
                    Console.WriteLine("(3) Varolan numarayı günncelleme. \n (4) Rehberi listelemek. ");
                    Console.WriteLine("(5) Rehberde arma yapmak. \n (6) Islemleri sonlandırmak icin.  ");
                    a = Convert.ToInt32(Console.ReadLine());
                    switch(a)
                    {
                        case 1:
                            string isim=Console.ReadLine();
                            string soyAd=Console.ReadLine();
                            string No=Console.ReadLine();
                            liste1.Add(new Kisi(isim,soyAd,No));
                            break;
                        case 2:
                            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                            nameFind=Console.ReadLine();
                            liste1.Remove(liste1.Find(x => x.Name.Contains(nameFind)));
                            break;

                        case 3:
                            Guncelleme guncel=new Guncelleme();
                            guncel.kisiGuncelleme(liste1);
                            if (guncel.sonlandi()==1)
                                {
                                    Console.WriteLine("Güncelleme sonlandı");
                                }
                            break;
                        case 4:
                            Listele yeniList=new Listele();
                            yeniList.liste(liste1);
                            break;
                        case 5:
                            KisiBulma kisi=new KisiBulma();
                            kisi.kisiBul(liste1);
                            break;
                }
                }while(a!=6);
                
                // if (a==1)
                // {
                //     string isim=Console.ReadLine();
                //     string soyAd=Console.ReadLine();
                //     string No=Console.ReadLine();
                //     liste1.Add(new Kisi(isim,soyAd,No));
                // }
                // if (a==2)
                // {
                //     Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                //     nameFind=Console.ReadLine();
                //     liste1.Remove(liste1.Find(x => x.Name.Contains(nameFind)));
                // }
                // if (a==3)
                // {
                //     Guncelleme guncel=new Guncelleme();
                //     guncel.kisiGuncelleme(liste1);
                //     if (guncel.sonlandi()==1)
                //     {
                //         Console.WriteLine("Güncelleme sonlandı");
                //     }
                // }
                // if (a==4)
                // {
                //     Listele yeniList=new Listele();
                //     yeniList.liste(liste1);
                // }
                // if (a==5)
                // {
                //     KisiBulma kisi=new KisiBulma();
                //     kisi.kisiBul(liste1);
                // }
                // if (a==6)
                // {
                //     b=0;
                // }
            }
        
    }

    
}