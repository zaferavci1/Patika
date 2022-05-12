public class HarmonikOrtalama {
    public static void main(String[] args) {
        double[] dizi={45,56,78,89,12,23};
        double value=1/dizi[0];
        for (int i=1;i< dizi.length;i++){
            value+=(1/dizi[i]);
        }
        double harmonikOrtalama= dizi.length/value;
        System.out.println("Harmonik Ortalama: "+harmonikOrtalama);
    }
}
