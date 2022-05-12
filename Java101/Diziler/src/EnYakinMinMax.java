import java.util.Arrays;
import java.util.Scanner;

public class EnYakinMinMax {
    public static void main(String[] args) {
        int[] dizi = {12, 23, 56, 89, 45, 78, 24, 59};

        int a = 0, b = 0, maxSayi = 0;
        int[] min = new int[dizi.length];
        int[] max = new int[dizi.length];

        Scanner abc = new Scanner(System.in);
        System.out.print("Sayi giriniz: ");
        int value = abc.nextInt();

        for (int i = 0; i < dizi.length; i++) {
            if (dizi[i] < value) {

                min[a] = dizi[i];
                a++;
            } else if (dizi[i] > value) {
                max[b] = dizi[i];
                b++;
            }
        }

        System.out.println("Dizi: "+Arrays.toString(dizi));
        System.out.println("Girilen sayi: "+value);
        Arrays.sort(min);
        System.out.println("Girilen sayidan kucuk en yakin sayi : " + min[(min.length) - 1]);

        Arrays.sort(max);
        for (int i = 0; i < max.length; i++) {
            if (max[i] > 0) {
                maxSayi = max[i];
                break;
            }
        }
        System.out.print("Girilen sayidan buyuk en yakin sayi : " + maxSayi);




    }
}


