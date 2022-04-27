import java.util.Scanner;

public class ArmstrongSayi {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);


        System.out.println("Sayi giriniz: ");
        int sayi = abc.nextInt();
        int basamakSayisi = 0,b=sayi,i,toplam=0,c,kontrol=sayi;


        while (sayi != 0) {

            basamakSayisi++;
            sayi /= 10;

        }
        int armstrong[] = new int[basamakSayisi];

        //basamakları bir diziye atadık

        for ( i=0;i<basamakSayisi;i++){
            armstrong[i]=b%10;
            b=b/10;
        }
        //dizideki sayıilarin üssünü aldik ve diziye atadik
        for ( i=0;i<basamakSayisi;i++){
            c=armstrong[i];
            for (int j=1;j<basamakSayisi;j++){
                armstrong[i]=c*armstrong[i];
            }
        }
        //dizideki sayilari topladik
        for ( i=0;i<basamakSayisi;i++){
            toplam+=armstrong[i];
        }

        if (kontrol==toplam)
            System.out.println("Sayi bir Armstrong sayidir: "+toplam);
        else
            System.out.println("Bir Armstrong sayi degildir. ");
    }
}
