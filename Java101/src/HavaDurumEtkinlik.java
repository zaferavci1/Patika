import java.util.Scanner;

public class HavaDurumEtkinlik {
    public static void main(String[] args) {
        Scanner abc = new Scanner(System.in);

        System.out.println("Hava sicakligini giriniz: ");
        int sicakilik = abc.nextInt();
        String etkinlik;

        etkinlik = (sicakilik <= 5) ? "Kayak Yapilabilibir Bir Hava" :(sicakilik > 5 && sicakilik <= 15) ? "Sinemaya Gidilebilir" : (sicakilik > 5 && sicakilik <= 15) ? "Sinemaya Gidilebilir" : (sicakilik > 15 && sicakilik <= 25) ? "Piknige Gidilebilir" : "Yüzmek Icin Güzel Bir Hava";

//        if (sicakilik <= 5)
//            System.out.println("Kayak Yapilabilibir Bir Hava");
//        else if (sicakilik > 5 && sicakilik <= 15)
//            System.out.println("Sinemaya Gidilebilir");
//        else if (sicakilik > 15 && sicakilik <= 25)
//            System.out.println("Piknige Gidilebilir");
//        else if (sicakilik>25)
//            System.out.println("Yüzmek Icin Güzel Bir Hava");

         System.out.println(etkinlik);


    }
}