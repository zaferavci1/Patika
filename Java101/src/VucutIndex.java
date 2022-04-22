import java.util.Scanner;
public class VucutIndex {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);
        System.out.print("Boyunuzu giriniz : ");
        double boy = abc.nextDouble();
        System.out.print("kilonuzu Giriniz : ");
        double kilo = abc.nextDouble();
        double vke = kilo / (boy * boy);
        System.out.println("Vucut Kitle İndeksiniz : " + vke);
    }
}
