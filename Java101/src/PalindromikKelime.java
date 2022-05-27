import java.util.Scanner;

public class PalindromikKelime {
    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);

        System.out.print("Kelime Giriniz: ");
        String word= abc.next(),kelime = null;
        int a=word.length(), j=0;

        char[] palindromik=new char[a];

        for (int i=a-1;i>=0;i--){
            palindromik[j]=word.charAt(i);
            j++;
        }
        String str = new String(palindromik);
        if (word.equals(str)){
            System.out.println("Girdiginiz kelime bir palindromik kelimedir: "+str);
        }
        else
            System.out.println("Palindromik kelime degildir ");

    }
}
