import java.util.Scanner;
public class BasitHesapMakinesi {
    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.println("Sayi'1 i giriniz: ");
        int sayi1= abc.nextInt();
        System.out.println("Sayi2'yi giriniz: ");
        int sayi2= abc.nextInt();


        System.out.println("1 Toplama\n2 Cikarma\n3 Carpma \n4 Bolme");
        int islem= abc.nextInt();

        switch (islem)
        {
            case 1:
                System.out.println("Sonuc: "+(sayi1+sayi2)); break;
            case 2:
                System.out.println("Sonuc: "+(sayi1-sayi2));break;
            case 3:
                System.out.println("Sonuc: "+(sayi1*sayi2));break;
            case 4:
                System.out.println("Sonuc: "+(sayi1/sayi2));break;
        }

    }
}
