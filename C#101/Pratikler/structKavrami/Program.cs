using System;

namespace structKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen=new Dikdortgen();
            dikdortgen.kisaKenar=4;
            dikdortgen.uzunKenar=4;
            Console.WriteLine("Class alan hesabı: {0} ",dikdortgen.Alanhesapla());

            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.kisaKenar=5;
            dikdortgen_struct.uzunKenar=4;
            Console.WriteLine("Struct alan hesabı: {0} ",dikdortgen_struct.Alanhesapla());

        }
    }
    class Dikdortgen
    {
        public int kisaKenar,uzunKenar;
        public long Alanhesapla(){
            return this.kisaKenar*this.uzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int kisaKenar,uzunKenar;
        public long Alanhesapla(){
            return this.kisaKenar*this.uzunKenar;
        }
    }
}