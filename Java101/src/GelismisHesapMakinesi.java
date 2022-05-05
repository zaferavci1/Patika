import java.util.Scanner;

public class GelismisHesapMakinesi {

    static int Topla(){
        int result=0,i=0,sayi;
        Scanner abc = new Scanner(System.in);
        while(true){
            System.out.print(++i + ". Sayiyi Giriniz:");
            sayi=abc.nextInt();
            if (sayi==0)
                break;
            result+=sayi;
            System.out.println("Toplam: "+result);

        }
        return result;
    }

    static int Cikar(){
        int result=0,sayi,a;
        Scanner abc = new Scanner(System.in);
        System.out.print("Kac Tane Sayi Gireceksiniz:");
        a=abc.nextInt();

        for (int i=1;i<=a;i++){
            System.out.print(i + ". Sayiyi Giriniz:");
            sayi=abc.nextInt();
            if (i==1){
                result=sayi;
                continue;
            }

        result-=sayi;
        }
        return result;
    }

    static int Carpma(){
        int result=0,sayi,a;
        Scanner abc = new Scanner(System.in);
        System.out.print("Kac Tane Sayi Gireceksiniz:");
        a=abc.nextInt();

        for (int i=1;i<=a;i++){
            System.out.print(i + ". Sayiyi Giriniz:");
            sayi=abc.nextInt();
            if (i==1){
                result=sayi;
                continue;
            }
            else if (sayi == 1)
                break;

            else if (sayi == 0) {
                result = 0;
                break;
            }

            result*=sayi;
        }
        return result;
    }

    static double Bolme(){
        double result=0.0,sayi,a;
        Scanner abc = new Scanner(System.in);
        System.out.print("Kac Tane Sayi Gireceksiniz:");
        a=abc.nextInt();

        for (int i=1;i<=a;i++){
            System.out.print(i + ". Sayiyi Giriniz:");
            sayi=abc.nextInt();
            if (i==1){
                result=sayi;
                continue;
            }
            else if(sayi==0){
                System.out.println("Böleni 0 giremezsiniz.");
                continue;}

            result/=sayi;
        }
        return result;

    }

    static int Us(){
        int taban,us,a;
        Scanner abc = new Scanner(System.in);
        System.out.println("Tabani giriniz: ");
        taban=abc.nextInt();
        System.out.println("Us u giriniz:");
        us= abc.nextInt();
        a=taban;

        for (int i=1;i<us;i++){
            taban=a*taban;
        }
        return taban;
    }

    static int Faktoriyel(){
        Scanner abc = new Scanner(System.in);
        System.out.print("\nFaktoriyel Sayisini Giriniz: ");
        int a=abc.nextInt(),b=1;
        for (int i=a;i>0;i--){
            b*=i;
        }
        return b;
    }

    static int Mod(){
        Scanner abc = new Scanner(System.in);
        System.out.print("Modu Alinacak Sayiyi Giriniz: ");
        int a=abc.nextInt();
        System.out.print("Modu Giriniz: ");
        int b= abc.nextInt();
        int result=a%b;
        return  result;
    }

    static void Dikdortgen(){
        Scanner abc = new Scanner(System.in);
        System.out.print("Dikdortgenin uzun kenarini giriniz: ");
        int a= abc.nextInt();
        System.out.print("Dikdotgenin kisa kenrini giriniz: ");
        int b= abc.nextInt(),alan=a*b,cevre=(a+b)*2;
        System.out.println("Alan: "+alan+"\n"+"Cevre: "+cevre);
    }


    public static void main(String[] args) {

        Scanner abc = new Scanner(System.in);
        int select;
        String menu = "\n1- Toplama İşlemi\n"
                + "2- Çıkarma İşlemi\n"
                + "3- Çarpma İşlemi\n"
                + "4- Bölme işlemi\n"
                + "5- Üslü Sayı Hesaplama\n"
                + "6- Faktoriyel Hesaplama\n"
                + "7- Mod Alma\n"
                + "8- Dikdörtgen Alan ve Çevre Hesabı\n"
                + "0- Çıkış Yap\n";



        do {
            System.out.println(menu+"Hangi islemi yapmak istersiniz");
            select= abc.nextInt();
                switch (select) {
                    case 1:
                        System.out.print("Toplam: "+ Topla());
                        break;
                    case 2:
                        System.out.print("Sonuc: " + Cikar());
                        break;
                    case 3:
                        System.out.print("Carpma: "+ Carpma());
                        break;
                    case 4:
                        System.out.print("Bolme: "+ Bolme());
                        break;
                    case 5:
                        System.out.print("Us: "+ Us());
                        break;
                    case 6:
                        System.out.print("Faktoriyel: "+ Faktoriyel());
                        break;
                    case 7:
                        System.out.print("Mod: " + Mod());
                        break;
                    case 8:
                        Dikdortgen();
                        break;
                    case 0:
                        break;
                    default:
                        System.out.println("Yanlis Bir Deger Giridiniz!");
                }



        }while (select!=0);
    }
}
