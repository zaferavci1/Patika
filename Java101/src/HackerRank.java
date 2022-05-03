import java.util.Scanner;

public class HackerRank {

    public static void Patika(int num){
        num--;
        if (num == 0)
            return;
        System.out.print(num + ",");
        Patika(num);
    }


    public static void main(String[] args) {

        Patika(4);
    }

}

