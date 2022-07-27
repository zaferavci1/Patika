namespace ToDO
{
    class Kart
    {
        private string baslik,icerik,kartsahibi,buyukluk;
        public string Baslik { 
            get {return baslik;} 
            set { baslik = value;} }
        public string Icerik { 
            get {return icerik;} 
            set { icerik = value;}
         }
        public string KartSahibi { 
            get {return kartsahibi;} 
            set { kartsahibi = value;}
         }
        public string Buyukluk { 
            get {return buyukluk;} 
            set { buyukluk = value;}
         }

        public Kart(string basik, string icerik, string kartsahibi,string buyukluk)
        {
            this.baslik = basik;
            this.icerik = icerik;
            this.kartsahibi = kartsahibi;
            this.buyukluk=buyukluk;
        }
        
    }
}