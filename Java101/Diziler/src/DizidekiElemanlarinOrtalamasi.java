import java.sql.Array;

public class DizidekiElemanlarinOrtalamasi {
    public static void main(String[] args) {
        int[] dizi = {8, 10, 15, 16, 23, 24};
        int value = 0;
        for (int i = 0; i < dizi.length; i++) {
            value += dizi[i];
        }
        int ortalama = value / (dizi.length);
        System.out.println("Dizinin Ortalamasi: " + ortalama);
    }
}
