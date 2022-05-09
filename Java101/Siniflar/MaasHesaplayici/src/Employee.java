public class Employee {
    String name, surname;
    int salary, workHours, hireYear,tax,ilkMaas;

    Employee(String name, String surname, int salary, int workHours, int hireYear) {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
        this.ilkMaas = salary;
        this.workHours = workHours;
        this.hireYear = hireYear;
        this.tax=0;
    }
    public int tax(){
        if (this.salary>1000){
            this.tax=(this.salary*3)/100;
        }
        else
            this.tax=0;
        return tax;
    }

    public void riseSalary() {
        if ((2021 - this.hireYear) < 10)
            this.salary += (this.salary * 5) / 100;

        else if ((2021 - this.hireYear) > 9 && (2021 - this.hireYear) < 20)
            this.salary += (this.salary * 10) / 100;

        else if ((2021 - this.hireYear) > 19)
            this.salary += (this.salary * 15) / 100;

    }

    public int bonus(){
        if (this.workHours>40){
            this.salary+=(this.workHours-40)*30;
        }
        return (this.workHours-40)*30;
    }


    public void tostring(){
        System.out.println("Adi: "+this.name+" "+this.surname+"\nMaasi: "+this.ilkMaas+"\nCalisma Saati: "+this.workHours+"\nBaslangic Yili: "+this.hireYear
        +"\nVergi: "+this.tax()+"\nBonus: "+this.bonus()+"\nMaas Artisi: "+(this.salary-this.ilkMaas)+"\nToplam Maas: "+this.salary);
    }

}


