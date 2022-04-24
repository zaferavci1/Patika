import java.util.Scanner;

public class DortveBesUsAlma {
    public static void main(String[] args) {

        Scanner abc= new Scanner(System.in);
        System.out.println("Kaca kadar us alinsin: ");
        int us= abc.nextInt(),dort=1,bes=1;

        for (int i=1;i<=us;i++){
            dort=4*dort;
            bes=5*bes;
        }
        System.out.println("4'un "+us+". kuvveti "+dort+"\n5'in "+us+". kuvveti "+bes);

    }
}
