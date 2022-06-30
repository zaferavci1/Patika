import java.util.Random;
import java.util.Scanner;

public class mine {
    int satir,sutun,mayinSayisi,kullaniciSatir,kullaniciSutun,bombaSayisi;
    Scanner abc = new Scanner(System.in);
    Random r = new Random();
    String[][] tarla;

    public void run(){
        System.out.print("Diznin satir degerini giriniz: ");
        this.satir = abc.nextInt();
        System.out.print("Diznin sutun degerini giriniz: ");
        this.sutun = abc.nextInt();
        tarlaOluştur(this.satir,this.sutun);
        mayinKoy(this.satir,this.sutun);
        tarlaYazdir(this.satir,this.sutun);
        sec();
    }
    public  void tarlaOluştur(int a,int b){
        tarla=new String[a][b];
        for (int i = 0; i < a; i++) {
            for (int j = 0; j <b; j++) {
                this.tarla[i][j] = "0";
            }
        }
    }
    public void mayinKoy(int a,int b){

         mayinSayisi=(a*b)/4;
        for (int i = 0; i < mayinSayisi; i++) {
            int c = r.nextInt(this.satir);
            int d = r.nextInt(this.sutun);
            this.tarla[c][d] = "*";
        }
    }
    public void tarlaYazdir(int a,int b){
        for (int i = 0; i < a; i++) {
            for (int j = 0; j < b; j++) {
                System.out.print(" " + this.tarla[i][j]);
            }
            System.out.println();
        }
    }
    public void sec(){
        int satirr,sutunn;
        satirr=satirSec();
        sutunn=sutunSec();
        this.bombaSayisi=0;
        while (this.tarla[satirr][sutunn]!="*")
        {





        }




    }





    public int  satirSec(){
        System.out.print("satir giriniz");
        this.kullaniciSatir= abc.nextInt();
        if(this.kullaniciSatir>this.satir){
            System.out.println("boyutu astiniz");
            return satirSec();
        }
        else
            return kullaniciSatir;
    }
    public int sutunSec(){
        System.out.print("sutun giriniz");
        this.kullaniciSutun= abc.nextInt();
        if (this.kullaniciSutun>this.sutun){
            System.out.println("boyutu astiniz");
            return sutunSec();
        }
        else
            return kullaniciSutun;
    }
}








