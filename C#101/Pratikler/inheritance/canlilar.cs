
namespace inheritance
{
    
   public sealed class canlilar
    {
        protected void Beslenme(){
        Console.WriteLine("Canlilar Beslenir");
        }

        protected void Solunum(){
        Console.WriteLine("Canlilar Beslenir");
        }

        protected void Bosaltim(){
        Console.WriteLine("Canlilar bosaltim Yapar");
        }
        public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar nuyaranlara tepki verir");
        }
    }
    //Sealed anahtar kelimesi kalıtım vermeyi engelliyor 
    //Polymorphisim virtual fonksiyon ile gerçekleştirdik
    //Virtual anahtar kelimesiyle yaılmış bir metot herhangi bir yerden override yapılarak- 
    //tekrardan içeriği değiştirilebilir
    
}
