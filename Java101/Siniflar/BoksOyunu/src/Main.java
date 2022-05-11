import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Fighter f1=new Fighter("Serkan",13,80,100,0);
        Fighter f2=new Fighter("Zafer",13,75,100,0);
        Random a=new Random();
        int random=a.nextInt(2);

        if (random==1){
            Ring r=new Ring(f1,f2,50,100);
            r.run();
        }
        else if (random==0){
            Ring r=new Ring(f2,f1,50,100);
            r.run();
        }


    }
}
