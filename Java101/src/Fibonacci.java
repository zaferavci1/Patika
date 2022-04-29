import java.util.Scanner;

public class Fibonacci {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);

        System.out.println("Fibonacci serisi kaca kadar devam etsin ");
        int n= abc.nextInt(),a=0,b=1,c=0;
        System.out.println(a);
        for (int i=0;i<n;i++){

            a+=b;
            c=a;
            a=b;
            b=c;
            System.out.println(a);
        }

    }
}
