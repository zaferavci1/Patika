import java.util.Scanner;

public class Kombinasyon {
    public static void main(String[] args) {


        Scanner abc=new Scanner(System.in);
        double c,d,kombinasyon,a;
        System.out.println("c'yi giriniz");
        c=abc.nextInt();
        System.out.println("d'yi giriniz");
        d=abc.nextInt();
        System.out.println("Kombinasyon C("+c+","+d+")");

        a=c-d;
        kombinasyon=Faktoriyel(c)/(Faktoriyel(d)*Faktoriyel(a));
        System.out.println(kombinasyon);



    }
    public static double Faktoriyel(double n){
        double a,b=1;
       for (a=1;a<=n;a++){
           b=b*a;
       }
        return b;
    }
}
