
namespace UebungTempreatur
{
    public class Temperatur
    {

        public int Grad { get; set; }

        public void Anzeigen()
        {
            Console.WriteLine($"Die aktuelle Temperatur beträgt {Grad} Grad.");
        }
        public void Erhoehen()
        {
            Grad += 1;
            Console.WriteLine($"Die Temperatur wurde um 1°C erhöht und liegt nun bei {Grad}°C. ");
        }

        public void Senken()
        {
            Grad -= 1;
            Console.WriteLine($"Die Temperatur wurde um 1°C gesenkt und liegt nun bei {Grad}°C. ");
        }

    }
}
