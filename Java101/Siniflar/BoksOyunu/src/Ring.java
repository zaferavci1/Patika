public class Ring {
    Fighter f1;
    Fighter f2;
    int minWeight, maxWeight;

    public Ring(Fighter f1, Fighter f2, int minWeight, int maxWeight) {
        this.f1 = f1;
        this.f2 = f2;
        this.maxWeight = maxWeight;
        this.minWeight = minWeight;
    }

    public void run() {
        if (checkWeight()) {
            while (f1.health > 0 && f2.health > 0){
                System.out.println("======== YENİ ROUND ===========");
                f2.health=f1.vurus(f2);
                if (isWin()){
                    break;
                }
                f1.health=f2.vurus(f1);
                if (isWin()){
                    break;
                }
                printScore();
            }

        }else
            System.out.println("Sporcuların Agirliklari uyusmuyor.");
    }

    public boolean checkWeight() {
        return (f1.weight <= maxWeight && f1.weight >= minWeight) && (f2.weight <= maxWeight && f2.weight >= minWeight);
    }

    public boolean isWin(){
        if (f1.health==0){
            System.out.println("Maci kazanan: "+f2.name);
            return true; }
        else if (f2.health==0){
            System.out.println("Maci kazanan: "+f1.name);
            return true; }
        return false;
    }

    public void printScore(){
        System.out.println("\n--------------");
        System.out.println(f1.name+" Kalan can:\t "+f1.health);
        System.out.println(f2.name+" Kalan can:\t "+f2.health);
    }


}











