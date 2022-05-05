import java.util.Scanner;

public class RecursiveUsAlma{

    static int pow(int us,int taban){
        if (us>-1)
            return pow(us,taban);
        us--;
        return us*taban;
    }


    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.print("Tabani giriniz: ");
        int taban= abc.nextInt();
        System.out.print("Us u giriniz: ");
        int us=abc.nextInt();
        System.out.println( pow(us,taban));

    }
}
