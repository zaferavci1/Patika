public class BHarfiYazdirma {
    public static void main(String[] args) {
        String[][] dizi = new String[11][7];
        for (int i = 0; i < 11; i++) {
            for (int j = 0; j < 7; j++) {
                dizi[i][j]=" ";
            }
        }
        for (int i = 0; i < 11; i++) {
            for (int j = 0; j < 7; j++) {
                if (i == 0 && j < 6)
                    dizi[i][j] = "*";
                else if ((i > 0 && i < 5) && (j > 0 && j < 6))
                    dizi[i][j] = " ";
                else if ((i > 0 && i < 5) && (j > 5 && j <= 7))
                    dizi[i][j] = "*";
                else if ((i == 5) && (j < 6))
                    dizi[i][j] = "*";
                else if ((i > 5 && i < 10) && (j > 0 && j < 6))
                    dizi[i][j] = " ";
                else if ((i > 5 && i < 10) && (j > 5 && j <= 7))
                    dizi[i][j] = "*";
                else if ((i == 10) && (j < 6))
                    dizi[i][j] = "*";
                dizi[10][j]="*";
            }
            dizi[i][0] = "*";
        }
        for (int i=0;i<11;i++){
            for (int j=0;j<7;j++)
            {
                System.out.print(dizi[i][j]);
            }
            System.out.print("\n");
        }
    }
}
