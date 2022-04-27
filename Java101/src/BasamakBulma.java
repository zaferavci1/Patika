import java.util.Scanner;


public class BasamakBulma {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);


        System.out.println("Sayi giriniz: ");
        int sayi = abc.nextInt();
        int basamakSayisi = 0,b=sayi,i,toplam=0,c,kontrol=sayi;


        while (sayi != 0) {

            basamakSayisi++;
            sayi /= 10;

        }
        System.out.println("Basamak sayisi: "+basamakSayisi);



    }

}
