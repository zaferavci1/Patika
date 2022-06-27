import java.util.Locale;
import java.util.Scanner;

public class HackerRank{


    public static void main(String[] args) {

        int x=0;
        Scanner abc=new Scanner(System.in);
        String s=abc.nextLine();
        Scanner ab=new Scanner(s);
        while(ab.hasNext()){
            x++;
            if (x==4)
                break;
        }
            System.out.println(x);

    }






}