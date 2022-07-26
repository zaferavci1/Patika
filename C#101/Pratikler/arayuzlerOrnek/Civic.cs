
namespace arayuzlerOrnek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOusur()
        {
            return 4;
        }

        public renkk StandartRenk()
        {
            return renkk.Beyaz;
        }
    }
}