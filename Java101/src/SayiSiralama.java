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
            System.out.println("En buyuk sayi: "+x);
            if (y>z){
                System.out.println("Ortadaki sayi: "+y);
                System.out.println("En kucuk sayi: "+z);
            }
            else if (z>y){
                System.out.println("Ortadaki sayi: "+z);
                System.out.println("En kucuk sayi: "+y);
            }

        }
        else if (y > x && y > z) {
            System.out.println("En buyuk sayi: "+y);
            if (x>z)
            {
                System.out.println("Ortadaki sayi: "+x);
                System.out.println("En kucuk sayi: "+z);
            }
            else if (z>x){
                System.out.println("Ortadaki sayi: "+z);
                System.out.println("En kucuk sayi: "+x);
            }
        }
        else if (z>x&&z>y){
            System.out.println("En buyuk sayi: "+z);
            if (x>y){
                System.out.println("Ortadaki sayi: "+x);
                System.out.println("En kucuk sayi: "+y);
            }
            else if (y>x){
                System.out.println("Ortadaki sayi: "+y);
                System.out.println("En kucuk sayi: "+x);
            }
        }

    }
}
