namespace FirstApp {

    class VypisInformace {

        private string nazev;

        private string autor;

        private int rokVydani;

        public VypisInformace(){
        nazev = "Nazev Knihy";
        autor = "Nazev autora";
        rokVydani = 0;
    }
        public VypisInformace(string nazev, string autor, int rokVydani){
            this.nazev = nazev;
            this.autor = autor;
            this.rokVydani = rokVydani;
        }
        public string Nazev{
        
        get{return nazev;}
        set{this.nazev = value;}
        }
        public string Autor{
        
        get{return autor;}
        set{this.autor = value;}
        }
        public int RokVydani{
        
        get{return rokVydani;}
        set{this.rokVydani = value;}
        }

    public override string ToString()
    {return Nazev +" " + Autor + " " + RokVydani;}
    }
}