import java.util.Scanner;
public class ManavHesap {
    public static void main(String[] args) {
        Scanner abc=new Scanner(System.in);
        String Armut="Armut",elma="Elma",Domates="Domates",Muz="Muz",Patlican="Patlican";
        int Arm=0,elm=0,Doma=0,Mu=0,Patli=0;
        System.out.println("Kac KG Armut Aldiniz : ");
        Arm=abc.nextInt();

        System.out.println("Kac KG Elma Aldiniz : ");
        elm =abc.nextInt();

        System.out.println("Kac KG Domates Aldiniz : ");
        Doma=abc.nextInt();

        System.out.println("Kac KG Muz Aldiniz : ");
        Mu=abc.nextInt();

        System.out.println("Kac KG Patlican Aldiniz : ");
        Patli=abc.nextInt();

        double total=Arm*2.14+elm*3.67+Doma*1.11+Mu*0.95+Patli*5;
        System.out.println("toplam Tutar : "+total);
    }
}
