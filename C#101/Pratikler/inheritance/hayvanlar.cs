
    public class hayvanlar:canlilar
    {
        protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
    }

    public class Surungenler:hayvanlar
    {
        public Surungenler(){
                base.Adaptasyon();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
        }
        public void SurunerekHareketEtmek(){
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:hayvanlar
    {
        public Kuslar(){
                base.Adaptasyon();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
        }
        public void Ucmak(){
            Console.WriteLine("Kusllar Ucar.");
        }
    }