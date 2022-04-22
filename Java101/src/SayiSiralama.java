import java.util.Scanner;

public class SayiSiralama {
    public static void main(String[] args) {

        Scanner abc = new Scanner(System.in);
        int x, y, z;

        System.out.println("Sayi 1'i giriniz");
        x = abc.nextInt();

        System.out.println("Sayi 2'yi giriniz");
        y = abc.nextInt();

        System.out.println("Sayi 3'u giriniz");
        z = abc.nextInt();

        if (x > y && x > z) {
            System.out.println(x);
        } else if (y > x && y > z) {
            System.out.println(y);
        } else if (z>x&&z>y){
            System.out.println(z);
        }

    }
}
