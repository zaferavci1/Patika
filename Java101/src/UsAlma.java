import java.util.Scanner;

public class UsAlma {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        int taban,us,a;
        System.out.println("Tabani giriniz: ");
        taban=abc.nextInt();
        System.out.println("Us u giriniz:");
        us= abc.nextInt();
        a=taban;

        for (int i=1;i<us;i++){
           taban=a*taban;
        }
        System.out.println(taban);
    }
}
