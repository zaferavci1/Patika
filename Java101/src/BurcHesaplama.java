import java.util.Scanner;

public class BurcHesaplama {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);

        System.out.println("Hangi ay dogdunuz sayi biciminde giriniz: ");
        int ay = abc.nextInt();

        System.out.println("Hangi gun dogdunuz sayi biciminde giriniz: ");
        int gun = abc.nextInt();

        if (ay==1){
            if (gun<=21){
                System.out.println("Oglak Burcusunuz");
            }
            else
                System.out.println("Kova Burcusunuz");
        }
        else if (ay==2){
            if (gun<=19)
                System.out.println("Kova Burcusunuz" );
            else
                System.out.println("Balik Burcusunuz");
        }
        else if (ay==3){
            if (gun>=20)
                System.out.println("Balik Burcusunuz");
            else
                System.out.println("Koc Burcusunuz");
        }
        else if (ay==4){
            if (gun<=20)
                System.out.println("Koc Burcusunuz");
            else
                System.out.println("Boga Burcusunuz");
        }
        else if (ay==5){
            if (gun<=21)
                System.out.println("Boga Burcusunuz");
            else
                System.out.println( "Ikizler Burcusunuz");
        }
        else if (ay==6){
            if (gun<22)
                System.out.println("Ikizler Burcusunuz");
            else
                System.out.println("Yengec Burcusunuz");
        }
        else if (ay==7){
            if (gun<=22)
                System.out.println("Yengec Burcusunuz");
            else
                System.out.println("Aslan Burcusunuz");
        }
        else if (ay==8){
            if (gun<=22)
                System.out.println("Aslan Burcusunuz");
            else
                System.out.println("Basak Burcusunuz");
        }
        else if (ay==9){
            if (gun<=22)
                System.out.println("Basak Burcusunuz");
            else
                System.out.println("Terazi Burcusunuz");
        }
        else if (ay==10){
            if (gun<=22)
                System.out.println("Terazi Burcusunuz");
            else
                System.out.println("Akrep Burcusunuz");
        }
        else if (ay==11){
            if (gun<=21)
                System.out.println("Akrep Burcusunuz");
            else
                System.out.println("Yay Burcusunuz");
        }
        else
            System.out.println("Bilgileriniz dogru degil");


    }
}
