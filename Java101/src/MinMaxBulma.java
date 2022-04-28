import java.util.Scanner;

public class MinMaxBulma {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        System.out.println("Kac tane sayi gireceksiniz: ");

        int n=abc.nextInt(),enBuyuk=0,enKucuk=0;
        int sayi[]=new int[n];

        for (int i=0;i<=n;i++){
            System.out.println(i+". degeri giriniz: ");
            sayi[i]=abc.nextInt();
        }

        for (int i=0;i<=n;i++){
            if (sayi[1+i]>sayi[i]){
                enBuyuk=sayi[1+i];
            }
        }
        System.out.println(enBuyuk);
    }
}
