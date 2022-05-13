import java.util.Arrays;
import java.util.Scanner;

public class DiziOlusturma {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);
        System.out.print("Dizi kac elemanli olsun: ");
        int a = abc.nextInt();
        int[] dizi = new int[a];

        System.out.println("Dizinin boyutu: "+a);
        for (int i = 0; i < a; i++) {
            System.out.print((i+1) + ". elemani giriniz: ");
            dizi[i]= abc.nextInt();
        }
        Arrays.sort(dizi);
        System.out.println(Arrays.toString(dizi));
    }
}
