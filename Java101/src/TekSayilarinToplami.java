import java.util.Scanner;

public class TekSayilarinToplami {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        int toplam=0,a=0;

        do {
            System.out.println("Sayi Giriniz: ");
            a= abc.nextInt();

            if (a%2==0&&a%4==0){
                toplam+=a;
            }
        }while (a%2==0);

        System.out.println("Cift ve 4'un kati \n Toplam: "+toplam);


    }
}
