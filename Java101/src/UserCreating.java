import java.util.Scanner;

public class UserCreating {
    public static void main(String[] args) {

        String veritabaniSifre="123456",veritabaniKullaniciAdi="zaferavci1";
        String sifre1 = "";
        Scanner abc = new Scanner(System.in);
        System.out.println("Kullanici Adinizi Giriniz");
        String kullanici = abc.nextLine();
        System.out.println("Sifrenizi Giriniz ");
        String sifre = abc.nextLine();

        //equals esitlik
        if (kullanici.equals(veritabaniKullaniciAdi) && sifre.equals(veritabaniSifre)) {
            System.out.println("Giriş Başarılı");
        } else {
            System.out.println("Bilgileriniz Yanlış");
            System.out.println("Şifrenizi Sıfırlamak İster Misiniz (E,H)");
            String sifirlama = abc.nextLine();
            if (sifirlama.equals("E")) {
                System.out.println("Yeni Şifrenizi Giriniz: ");
                sifre1 = abc.nextLine();
                if (!sifre1.equals(veritabaniSifre)) {
                    veritabaniSifre = sifre1;
                    System.out.println("Şifreniz Değiştirilmiştir");

                } else {
                    System.out.println("Yeni Şifreniz Eski şifrenizle aynı olamaz");
                }

            }

        }
    }
}


