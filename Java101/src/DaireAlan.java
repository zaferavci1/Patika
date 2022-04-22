import java.util.Scanner;
public class DaireAlan {
    public static void main(String[] args) {
        Scanner abc=new Scanner(System.in);
        int cap,aci;
        double pi=3.14,alan,dilimAlan,cevre;
        System.out.print("Yari Capi Giriniz : ");
        cap= abc.nextInt();
        alan=pi*cap*cap;
        System.out.println(" Alan : "+alan);
        cevre=2*pi*cap;
        System.out.println("Cevre : "+cevre);
        System.out.print("Aciyi Giriniz :");
        aci=abc.nextInt();
        dilimAlan=(alan*aci)/360;
        System.out.println("Dilim Alan : "+dilimAlan);

    }
}
