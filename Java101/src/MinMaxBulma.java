import java.util.Scanner;

public class MinMaxBulma {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        System.out.print("Kac tane sayi gireceksiniz: ");

        int n=abc.nextInt(),enBuyuk=0,enKucuk=0,a=0;

        for (int i=0;i<n;i++){
            System.out.println("sayi giriniz");
            enBuyuk=abc.nextInt();



            if (enBuyuk>enKucuk)
                a=enBuyuk;
            else if (enBuyuk<enKucuk)
                a=enKucuk;
        }
        System.out.println("En buyuk sayi: "+a);

    }
}