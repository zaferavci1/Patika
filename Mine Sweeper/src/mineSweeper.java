import java.util.Random;
import java.util.Scanner;

public class mineSweeper {

    public void mineSweeper() {

        Random r = new Random();
        Scanner abc = new Scanner(System.in);
        System.out.print("Diznin satir degerini giriniz: ");
        int satir = abc.nextInt();

        System.out.print("Diznin sutun degerini giriniz: ");
        int sutun = abc.nextInt();

        String mine[][] = new String[satir][sutun];
        for (int i = 0; i < satir; i++) {
            for (int j = 0; j < sutun; j++) {
                mine[i][j] = "0";
            }
        }

        //mayın sayisi
        int boyut = (satir * sutun) / 4;
        for (int i = 0; i < boyut; i++) {
            int a = r.nextInt(satir);
            int b = r.nextInt(sutun);
            mine[a][b] = "*";
        }
        for (int i = 0; i < satir; i++) {
            for (int j = 0; j < sutun; j++) {
                System.out.print("  " + mine[i][j]);
            }
            System.out.println();
        }

        System.out.print("Satir giriniz: ");
        int kullaniciSatir = abc.nextInt();
        System.out.print("Sutun giriniz: ");
        int kullaniciSutun = abc.nextInt();
        int etraf = 0;

        if (kullaniciSutun <= sutun && kullaniciSatir <= satir) {
            if (mine[kullaniciSatir][kullaniciSutun] == "*") {
                System.out.println("Mayina Bastiniz ");
            }
             if (kullaniciSatir == 0) {
                if (mine[kullaniciSatir ][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir ][kullaniciSutun ] == "*")
                    etraf++;

            }
             if (kullaniciSutun == 0) {
                if (mine[kullaniciSatir - 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun ] == "*")
                    etraf++;

            }
             if (kullaniciSutun == sutun) {
                if (mine[kullaniciSatir - 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun - 1] == "*")
                    etraf++;

            }
             if (kullaniciSatir == satir) {
                if (mine[kullaniciSatir - 1][kullaniciSutun] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun + 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir + 1][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir][kullaniciSutun - 1] == "*")
                    etraf++;

                 if (mine[kullaniciSatir - 1][kullaniciSutun - 1] == "*")
                    etraf++;

            }
             if (mine[kullaniciSatir - 1][kullaniciSutun] == "*"){
                etraf++;
            }
             if (mine[kullaniciSatir - 1][kullaniciSutun + 1] == "*"){
                etraf++;

            }
             if (mine[kullaniciSatir][kullaniciSutun + 1] == "*"){
                etraf++;
            }
             if (mine[kullaniciSatir + 1][kullaniciSutun + 1] == "*"){
                etraf++;

            }
             if (mine[kullaniciSatir + 1][kullaniciSutun] == "*"){
                etraf++;

            }
             if (mine[kullaniciSatir + 1][kullaniciSutun - 1] == "*"){
                etraf++;

            }
             if (mine[kullaniciSatir][kullaniciSutun - 1] == "*"){
                etraf+=1;

            }
             if (mine[kullaniciSatir - 1][kullaniciSutun - 1] == "*"){
                etraf+=1;
            }
        }
        System.out.println(etraf);
        mine[kullaniciSatir][kullaniciSutun] = Integer.toString(etraf);


        for (int i = 0; i < satir; i++) {
            for (int j = 0; j < sutun; j++) {
                System.out.print(" " + mine[i][j]);
            }
            System.out.println();
        }

    }
}
















