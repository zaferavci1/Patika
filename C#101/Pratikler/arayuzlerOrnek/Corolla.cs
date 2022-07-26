using System;

namespace arayuzlerOrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
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