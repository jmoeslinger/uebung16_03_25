
namespace UebungHandy
{
    public class Handy
    {

        public string Marke { get; set; }
        public string Modell { get; set; }
        public int AkkuProzent { get; set; }

        public void Anzeigen()
        {     Console.WriteLine($"Handy: {Marke}: {Modell}");
            Console.WriteLine($"Akku: {AkkuProzent}%");
        }
        public void Aufladen() 
        { Console.WriteLine($"Akku wird aufgeladen...");
            AkkuProzent = 100;
            Console.WriteLine($"Akku: {AkkuProzent}%");
        }

    }
}
