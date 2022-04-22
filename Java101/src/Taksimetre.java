import java.util.Scanner;
public class Taksimetre {
    public static void main(String[] args) {
        Scanner yol = new Scanner(System.in);
        System.out.print("Kac KM Gittiniz Giriniz: ");
        int km = yol.nextInt();
        float tutar = km / 2.20f;
        float k=0f;
        float fiyat = tutar > 20 ? (k=tutar+10) : (k=20);
        System.out.println("Odemeniz Gereken Fiyat: "+fiyat);
    }
}
