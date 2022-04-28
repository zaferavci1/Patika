import java.util.Scanner;

public class EbobEkok {
    public static void main(String[] args) {

        Scanner abc = new Scanner(System.in);

        int a, b,d,e, i = 1, ebob=0,c=1,ekok=0;
        System.out.println("\nEbob alacagimiz sayilari giriniz: ");
        a = abc.nextInt();
        b = abc.nextInt();
        //ilk sayinin küçük girildiği durumda
        if (a<=b) {
            do {
                if (a % i == 0 && b % i == 0)
                    ebob = i;
                i++;
            } while (i <= a);
            ekok=(a*b)/ebob;
            System.out.println("EKOK: "+ekok);
        }
        //ilk sayinin büyük girildiği durumda değişken dönüşümü yapılarak doğru sonuca gidildi
        else
        {
            c=b;
            b=a;
            a=c;
            do {
                if (a % i == 0 && b % i == 0)
                    ebob = i;
                i++;
            } while (i <= a);

            ekok=(a*b)/ebob;
            System.out.println("EKOK: "+ekok);
        }
        System.out.println("EBOB: "+ebob);




    }

}
