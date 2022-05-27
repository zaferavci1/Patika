import java.util.Scanner;

public class RecursiveAsalSayi {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);
        System.out.print("sayi giriniz: ");
        int number=abc.nextInt();
        boolean result=asalMi(number,2);
    }

    static boolean asalMi(int number, int i) {
        boolean result;
        if (i >= number) {
            System.out.println(number + " sayisi asaldir");
            result = true;
        } else if (number % i == 0) {
            System.out.println(number + " sayisi asal değildir");
            result = false;
        } else {
            result = asalMi(number, i + 1);
        }
        return result;
    }
}
