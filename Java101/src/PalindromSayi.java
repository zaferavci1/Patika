import java.util.Scanner;

public class PalindromSayi {
    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.print("Bir sayi giriniz =>");
        int sayi= abc.nextInt(),sonBasamak=0,temp=0,basamak=0,a,b;
        a=sayi;
        while (a!=0){
            basamak++;
            a/=10;
        }
        b=sayi;
       for (int i=0;i<basamak;i++){
           sonBasamak=sayi%10;
           temp=(temp*10)+sonBasamak;
           //sayini yanına sayi eklemek icin suoer bir yontem
           sayi/=10;
       }

        if (temp==b){
            System.out.println("Giriline  sayi Palindrom bir sayidir.");
        }
        else
            System.out.println("Palindrom bir sayi degildir");

    }
}
