import java.util.Arrays;
import java.util.Scanner;

public class SayiMinMax {
    public static void main(String[] args) {
        Scanner abc=new Scanner(System.in);
        System.out.print("Kac tane sayi gireceksiniz: ");
        int sayi= abc.nextInt();
        int[] dizi=new int[sayi];
        for (int i=0;i<sayi;i++){
            System.out.println("Dizinin "+i+". ci elemanini giriniz: ");
            dizi[i]=abc.nextInt();
        }
        Arrays.sort(dizi);
        System.out.println("Dizinin en büyük elemani: "+dizi[sayi-1]);
        System.out.println("Dizinin en büyük elemani: "+dizi[0]);

    }
}
