import java.util.Scanner;

public class CinZodyagiHesaplama {
    public static void main(String[] args) {
        Scanner abc= new Scanner(System.in);
        System.out.println("Dogum Yilinizi Giriniz: ");
        int yil=abc.nextInt(),kalan;
        kalan=yil%12;
        String zodyagi="";
        if (kalan==0)
            zodyagi="Maymun ";
        if (kalan==1)
            zodyagi="Horoz ";
        if (kalan==2)
            zodyagi="Kopek ";
        if (kalan==3)
            zodyagi="Domuz ";
        if (kalan==4)
            zodyagi="Fare ";
        if (kalan==5)
            zodyagi="Okuz ";
        if (kalan==6)
            zodyagi="Kaplan ";
        if (kalan==7)
            zodyagi="Tavsan ";
        if (kalan==8)
            zodyagi="Ejderha ";
        if (kalan==9)
            zodyagi="Yilan ";
        if (kalan==10)
            zodyagi="At ";
        if (kalan==11)
            zodyagi="Koyun ";

        System.out.println("Cin Zodaygi Burcunuz: "+zodyagi);


    }
}
