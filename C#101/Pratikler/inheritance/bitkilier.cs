
    public class bitkiler:canlilar
    {
        protected void Fotosentez(){
        Console.WriteLine("bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler:bitkiler
    {
        public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma(){
            
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }

    public class TohumsuzBitkiler:bitkiler
    {
        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Fotosentez();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
