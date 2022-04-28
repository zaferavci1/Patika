

public class YildizYapimi {
    public static void main(String[] args) {
        for (int i = 1; i <= 2; ++i) {
            for (int j = 1; j < 4; ++j) {
                if (i == 1) continue;
                System.out.print(i + j);
            }
        }
    }
}
