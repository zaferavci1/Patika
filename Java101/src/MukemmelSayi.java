import java.util.Scanner;

public class MukemmelSayi {
    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.println("Sayi giriniz: ");
        int sayi=0,toplam=0;
        sayi=abc.nextInt();

        int carpan[]=new int[sayi];
        for (int i=1;i<sayi;i++){
            if (sayi%i==0){
                carpan[i]=i;
            }

        }


        for (int i=0;i<sayi;i++)
            toplam+=carpan[i];

        if (toplam==sayi)
            System.out.println("Mukemmel sayidir: "+toplam);
        else
            System.out.println("Mukemmel sayi degildir.");
    }
}
