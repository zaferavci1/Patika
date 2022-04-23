import java.util.Scanner;

public class UcakBiletFiyat {
    public static void main(String[] args) {

        Scanner abc = new Scanner(System.in);

        int km,yas,tip;
        double normalFiyat,yasIndirimi,tipIndirimi;


        System.out.println("Kac Km gideceginizi giriniz: ");
         km = abc.nextInt();
        System.out.println("Yasinizi giriniz: ");
         yas = abc.nextInt();
        System.out.println("Yolculuk tipiniz nedir 1=>Gidis Donus | 2=> Sadece Gidis");
         tip = abc.nextInt();

        if (km > 0 && yas > 0 && (tip == 1 || tip == 2)) {
            normalFiyat=km*0.10;
            System.out.println("Normal Fiyat: "+normalFiyat);
            if (yas<12) {
                yasIndirimi=normalFiyat*0.5;
                normalFiyat=normalFiyat-yasIndirimi;
                System.out.println("Yas indirimi: "+yasIndirimi);
                if (tip==1){
                    tipIndirimi=normalFiyat*0.3;
                    normalFiyat=normalFiyat-tipIndirimi;
                    System.out.println("Indirimli Fiyat: "+normalFiyat);
                }
                else
                    System.out.println("Indirim tutari: "+yasIndirimi+" Indirimli Fiyat: "+normalFiyat );
            }

            else if (yas>12&&yas<24){
                yasIndirimi=normalFiyat*0.10;
                normalFiyat=normalFiyat-yasIndirimi;
                System.out.println("Yas indirimi: "+yasIndirimi);
                if (tip==1){
                    tipIndirimi=normalFiyat*0.3;
                    normalFiyat=normalFiyat-tipIndirimi;
                    System.out.println("Indirimli Fiyat: "+normalFiyat);
                }
                else
                    System.out.println("Indirim tutari: "+yasIndirimi+" Indirimli Fiyat: "+normalFiyat );
            }

            else if (yas>65){
                yasIndirimi=normalFiyat*0.3;
                normalFiyat=normalFiyat-yasIndirimi;
                System.out.println("Yas indirimi: "+yasIndirimi);
                if (tip==1){
                    tipIndirimi=normalFiyat*0.3;
                    normalFiyat=normalFiyat-tipIndirimi;
                    System.out.println("Indirimli Fiyat: "+normalFiyat);
                }
                else
                    System.out.println("Indirim tutari: "+yasIndirimi+" Indirimli Fiyat: "+normalFiyat );
            }


        }
        else
            System.out.println("Girilen Bilgiler Dogru Degil");

    }
}
