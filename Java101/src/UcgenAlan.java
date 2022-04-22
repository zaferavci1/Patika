
import java.util.Scanner;
public class UcgenAlan {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int ilk,iki,uc,u,alan;
        System.out.print("Ucgenin ilk kenarini giriniz: ");
        ilk= input.nextInt();
        System.out.print("Ucgenin ikinci kenarini giriniz: ");
        iki= input.nextInt();
        System.out.print("Ucgenin Ucuncu kenarini giriniz: ");
        uc= input.nextInt();
        u=(ilk+iki+uc)/2;
        alan=u*(u-ilk)*(u-iki)*(u-uc);

        System.out.println(Math.sqrt(alan));
    }
}
