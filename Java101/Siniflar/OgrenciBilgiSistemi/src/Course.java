import java.security.PublicKey;

public class Course {

    Teacher courseTeacher;
    String name,code,prefix;
    double note,sozlu;

    public Course(String name, String code, String prefix){
        this.name=name;
        this.code=code;
        this.prefix=prefix;
        this.note=0;
    }

    public void addTeacher(Teacher teacher){
        if (this.prefix.equals(teacher.branch)) {

            this.courseTeacher=teacher;
            System.out.println("Islem Basarili ");
        }else {
            System.out.println(teacher.name+" Akedemisyeni bu dersi veremez");
        }
    }

    public void printTeacher(){
        if (courseTeacher!=null){
            System.out.println(this.name+" Dersinin akedemisyeni"+courseTeacher.name);
        }
        else
            System.out.println(this.name+" dersine akdemisyen atanmamistir.");
    }
}
