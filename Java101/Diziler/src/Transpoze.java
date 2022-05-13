import java.util.Arrays;
import java.util.Scanner;

public class Transpoze {
    public static void main(String[] args) {

        Scanner abc=new Scanner(System.in);
        System.out.print("Dizi kac satirli olsun: ");
        int a= abc.nextInt();

        System.out.print("Dizi kac sutunlu olsun: ");
        int b= abc.nextInt(),i,j;

        int[][] dizi=new int[a][b];
        int[][] transpoz=new int[b][a];

        for (i=0;i<a;i++){
            for (j=0;j<b;j++){
                System.out.print(i+". satir elemanlarini giriniz: ");
                dizi[i][j]= abc.nextInt();

            }
        }


        for (i=0;i<a;i++){
            for (j=0;j<b;j++){
                System.out.print(dizi[i][j]+" ");
            }
            System.out.println();
        }
        System.out.println("------------------");
        for (i=0;i<b;i++){
            for (j=0;j<a;j++){
                System.out.print(dizi[j][i]+" ");
            }
            System.out.println();
        }
    }
}
