
namespace arayuzlerOrnek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOusur()
        {
            return 4;
        }

        public renkk StandartRenk()
        {
            return renkk.Gri;
        }
    }
}