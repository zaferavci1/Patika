import java.util.Scanner;

public class ArtikYilHesaplama {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        System.out.println("Yil Giriniz: ");
        int yil= abc.nextInt();
        if (yil%4==0){
            if (yil%100==0){
                if (yil/400==0){
                    System.out.println("Artik Yildir");
                }
                else
                    System.out.println("Artik Yil Degildir");
            }

            System.out.println("Artik Yildir");
        }
        else
            System.out.println("Artik Yil Degildir");


    }
}
