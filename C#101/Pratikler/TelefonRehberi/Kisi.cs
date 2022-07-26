namespace proje1
{
    class Kisi
    {
        string name,surName,telephone;

        public string Name { 
        get {return name;} 
        set { name = value;} }
        public string SurName { get { return surName;}
        set { surName = value;} }
        public string Telephone { 
        get { return telephone;} 
        set { telephone = value;} }

        public Kisi(string isim,string soysim,string no){
            this.name=isim;
            this.surName=soysim;
            this.telephone=no;
        }
    }
}