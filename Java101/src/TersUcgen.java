import java.util.Scanner;

public class TersUcgen {
    public static void main(String[] args) {
        Scanner abc=new Scanner(System.in);
        System.out.print("Kac basamakli olsun: ");
        int n= abc.nextInt();
        for (int i=n;i>=0;i--){
            for (int j=0;j<n-i;j++) {
                System.out.print(" ");
            }
            for (int j=0;j<=i*2;j++){
                System.out.print("*");
            }
            for (int k=n;k<=i;k++) {
                System.out.print(" ");
            }
            System.out.println();
        }

    }
}
