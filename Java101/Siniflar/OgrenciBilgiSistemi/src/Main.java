public class Main {
    public static void main(String[] args) {
        Course mat = new Course("Matematik", "MAT101", "MAT");
        Course fizik = new Course("Fizik", "FIZIK101", "FZK");
        Course kimya = new Course("Kimya", "KİMYA101", "KMY");

        Teacher t1 = new Teacher(" Yusuf Oguzhan", "05538826863", "FZK");
        Teacher t2 = new Teacher(" Cuma Hoca", "05399112323", "MAT");
        Teacher t3=new Teacher(" Zeynep Hoca","0531031314","KMY");

        mat.addTeacher(t2);
        mat.printTeacher();
        fizik.addTeacher(t1);
        fizik.printTeacher();
        kimya.addTeacher(t3);
        kimya.printTeacher();

        Student s1=new Student("Zafer","21110131011",1,mat,fizik,kimya);
        s1.addBulkExamNote(55,46,56);
        s1.addSozluNot(80,90,60);
        s1.isPass();

        Student s2=new Student("Serkan","21110131011",1,mat,fizik,kimya);
        s2.addBulkExamNote(89,56,23);
        s2.addSozluNot(80,90,100);
        s2.isPass();
    }
}
