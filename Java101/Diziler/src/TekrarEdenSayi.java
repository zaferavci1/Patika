import java.util.Arrays;

public class TekrarEdenSayi {
    public static void main(String[] args) {

        int[] dizi = {12, 45, 65, 89, 8, 23, 23,12, 45, 78, 65, 56};
        int[] tekrar = new int[dizi.length];
        int[] ciftTekrar = new int[dizi.length];
        int a = 0,b=0;
        for (int i = 0; i < dizi.length; i++) {
            for (int j = 0; j < dizi.length; j++) {
                if ((dizi[i] == dizi[j]) && (i != j)) {
                    tekrar[a] = dizi[i];
                    a++;
                }
            }
        }
        System.out.println(Arrays.toString(tekrar));
        System.out.println("---------Cift ve tekrar edenler--------------");

        for (int i = 0; i < dizi.length; i++) {
            for (int j = 0; j < dizi.length; j++) {
                if ((dizi[i] == dizi[j]) && (i != j) && (dizi[i] % 2 == 0)) {
                    ciftTekrar[b] = dizi[i];
                    b++;
                }
            }
        }
        System.out.println(Arrays.toString(ciftTekrar));
    }
}
