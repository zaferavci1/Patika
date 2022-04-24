import java.util.Scanner;

public class BolunmeUcVeDort {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);
        System.out.println("Dongu ne kadar donsun giriniz: ");
        int a = abc.nextInt(), toplam=0,sayac=0;
        for (int i = 1; i <= a; i++) {

            if ((i % 4 == 0) && (i % 3 == 0)) {
                toplam+=i;
                sayac++;
            }
        }

        System.out.println("Ortalama: "+(toplam=toplam/sayac));
    }
}
