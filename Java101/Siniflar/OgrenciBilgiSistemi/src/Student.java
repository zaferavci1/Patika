import java.security.PublicKey;

public class Student {
    String name, stuNo;
    int classes;
    Course mat;
    Course fizik;
    Course kimya;
    double avarage;
    boolean isPass;

    public Student(String name, String stuNo, int classes, Course mat, Course fizik, Course kimya) {
        this.name = name;
        this.stuNo = stuNo;
        this.classes = classes;
        this.mat = mat;
        this.fizik = fizik;
        this.kimya = kimya;
        calcAvarage();
        this.isPass = false;

    }

    public void addSozluNot(int matSozlu, int fizikSozlu, int kimyaSozlu) {
        if (matSozlu >= 0 && matSozlu <= 100)
            this.mat.sozlu=matSozlu;

        if (fizikSozlu >= 0 && fizikSozlu <= 100)
            this.fizik.sozlu=fizikSozlu;

        if (kimyaSozlu >= 0 && kimyaSozlu <= 100)
            this.kimya.sozlu=kimyaSozlu;
    }

    public void addBulkExamNote(int matNote, int fizikNote, int kimyaNote) {

        if (matNote >= 0 && matNote <= 100) {
            this.mat.note = (matNote*0.80)+(this.mat.sozlu*0.20);
        }

        if (fizikNote >= 0 && fizikNote <= 100) {
            this.fizik.note = (fizikNote*0.80)+(this.fizik.sozlu*0.20);
        }

        if (kimyaNote >= 0 && kimyaNote <= 100) {
            this.kimya.note = (kimyaNote*0.80)+(this.kimya.sozlu*0.20);
        }

    }

    public void isPass() {
        if (this.mat.note == 0 || this.fizik.note == 0 || this.kimya.note == 0) {
            System.out.println("Notlar Tam Olarak Girilmemis");
        } else {
            this.isPass = isCheckPass();
            printNote();
            System.out.println("Ortalama : " + this.avarage);
            if (this.isPass)
                System.out.println("Sinifi Gecti");
            else
                System.out.println("Sinifta Kaldi");
        }
    }

    public void calcAvarage() {
        this.avarage = (this.fizik.note + this.mat.note + this.kimya.note) / 3;
    }

    public boolean isCheckPass() {
        calcAvarage();
        return this.avarage > 55;
    }

    public void printNote() {
        System.out.println("=========================");
        System.out.println("Ogrenci : " + this.name);
        System.out.println("Matematik Notu : " + this.mat.note);
        System.out.println("Fizik Notu : " + this.mat.note);
        System.out.println("Kimya Notu : " + this.kimya.note);

    }

}



























