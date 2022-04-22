import java.util.Scanner;
public class KdvHesap {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        System.out.print("Aldiginiz urunun Fiyatini Giriniz: ");
        double fiyat;
        fiyat= input.nextInt();
        String kdv= fiyat<1000 && fiyat>0 ?"Kdv orani %18":"Kdv Orani %8";
        System.out.println(kdv);
        double kdv2;
        double kdv1=fiyat<1000 && fiyat>0 ? (kdv2=(fiyat*18)/100):(kdv2=(fiyat*8)/100);
        System.out.println("Kdv Tutari: "+kdv2);


    }
}
