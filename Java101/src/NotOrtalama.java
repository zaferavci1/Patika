import java.util.Scanner;
public class NotOrtalama {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int matNotu, fizikNotu, kimyaNotu, turkceNotu, tarihNotu, muzikNotu;
        System.out.print("Matematik Notu giriniz:");
        matNotu = input.nextInt();

        System.out.print("Fizik Notu giriniz:");
        fizikNotu = input.nextInt();

        System.out.print("Kimya Notu giriniz:");
        kimyaNotu = input.nextInt();

        System.out.print("Türkçe Notu giriniz:");
        turkceNotu = input.nextInt();

        System.out.print("Müzik Notu giriniz:");
        muzikNotu = input.nextInt();

        System.out.print("Tarih Notu giriniz:");
        tarihNotu = input.nextInt();

        float ortalama = matNotu + fizikNotu + kimyaNotu + tarihNotu + muzikNotu + turkceNotu;
        ortalama /= 6;
        System.out.println("Ortalamanız: " + ortalama);
        String durum = ortalama >= 60 ? "Gectiniz" : "Kaldiniz";
        System.out.println(durum);
    }

}
