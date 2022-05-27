import java.util.Scanner;

public class RecursiveUsAlma{


    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.print("Tabani giriniz: ");
        int taban= abc.nextInt();
        System.out.print("Us u giriniz: ");
        int us=abc.nextInt();
        System.out.println(usBul(taban,us));

    }
    static double usBul(int sayi, int us) {
        if (us <= 0)
            return 1;
        return usBul(sayi, us - 1) * sayi;
    }
}
