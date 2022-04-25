import java.util.Scanner;

public class HarmonikSeri {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        double harmonik=1,a=0;
        System.out.println("Harmonik serisini bulacagimiz sayiyi giriniz: ");
        a= abc.nextInt();

        for (double i=2;i<=a;i++){
            harmonik=harmonik+(1.00/i);
        }
        System.out.println(harmonik);

    }
}
