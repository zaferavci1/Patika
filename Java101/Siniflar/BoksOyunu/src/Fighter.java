public class Fighter {
    String name;
    int damage, health, weight;
    double dodge;

    public Fighter(String name, int damage, int weight, int health, double dodge) {
        this.name = name;
        this.damage = damage;
        this.health = health;
        this.weight = weight;
        this.dodge = dodge;
    }

    public int vurus(Fighter fighter) {
        System.out.println("---------");
        System.out.println(this.name + " => " + fighter.name + " " + this.damage + " hasar vurdu. ");

        if (fighter.dodge()){
            System.out.println(fighter.name+" gelen hasarı savurdu");
            return  fighter.health;
        }
        if(fighter.health-this.damage<0)
            return 0;

        return fighter.health-this.damage;
    }

    public boolean dodge(){
        double randomValue=Math.random()*100;//0.0  99.9
        return randomValue <=this.dodge;
    }
}
