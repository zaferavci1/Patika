
import java.util.Scanner;

public class SinifGecmeDurum {
    public static void main(String[] args) {

        Scanner abc = new Scanner(System.in);
        int matNotu, fizikNotu, kimyaNotu, turkceNotu, muzikNotu;
        System.out.print("Matematik Notu giriniz:");
        matNotu = abc.nextInt();

        System.out.print("Fizik Notu giriniz:");
        fizikNotu = abc.nextInt();

        System.out.print("Kimya Notu giriniz:");
        kimyaNotu = abc.nextInt();

        System.out.print("Türkçe Notu giriniz:");
        turkceNotu = abc.nextInt();

        System.out.print("Müzik Notu giriniz:");
        muzikNotu = abc.nextInt();

        int ortalama = 0;

        ortalama += (matNotu < 100 && matNotu > 0) ? matNotu : 0;
        ortalama += (fizikNotu < 100 && fizikNotu > 0) ? fizikNotu : 0;
        ortalama += (kimyaNotu < 100 && kimyaNotu > 0) ? kimyaNotu : 0;
        ortalama += (turkceNotu < 100 && turkceNotu < 0) ? turkceNotu : 0;
        ortalama += (muzikNotu < 100 && muzikNotu > 0) ? muzikNotu : 0;
        ortalama=ortalama/5;
        System.out.println(ortalama);


    }
}
