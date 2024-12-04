namespace Lezione4
{
    class Videogioco

    {

        public string Titolo { get; set; } = "";
        string Genere { get; set; } = "";
        string Casamadre { get; set; } = "";
        int AnnoUscita { get; set; } = 2000;
        bool Multigiocatore { get; set; } = false;
        int NumMaxGiocatori{ get; set; } = 1;
        public decimal Valutazione{ get; set; } = 0;
        decimal Prezzo { get; set; } = 0;


         public Videogioco() { }
        public Videogioco(decimal prezzo)
        {
            Prezzo = prezzo;
        }

        public void MostraPrezzo()
        {
            Console.WriteLine(Prezzo.ToString("C"));
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            Videogioco videogioco = new Videogioco();
            videogioco.Titolo = "Elden Ring";
            videogioco.Valutazione = Convert.ToDecimal(3.5);
            Console.WriteLine(videogioco, Titolo);
            videogioco.MostraPrezzo();
            Console.WriteLine("----------------------");
            Videogioco gioco2 = new Videogioco(Convert.ToDecimal(80.25));
            gioco2.MostraPrezzo();

        }

    }
}


