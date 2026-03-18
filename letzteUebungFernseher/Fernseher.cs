namespace letzteUebungFernseher
{
    public class Fernseher
    {
        public string Marke { get; set; }
        public int Kanal { get; set; }
        public bool IstAn { get; set; }

        public void Einschalten()
        {
            IstAn = true;
            Console.WriteLine($"Fernseher einschalten");
        }

        public void Ausschalten()
        {
            IstAn = false;
            Console.WriteLine($"Fernseher ausschalten");
        }

        public void KanalAnzeigen()
        {
            Console.WriteLine($"Aktueller Kanal: {Kanal}");


        }
    }
}
