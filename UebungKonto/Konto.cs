using System.Xml.Serialization;

namespace UebungKonto
{
    public class Konto
    {
        public string Inhaber { get; set; }
        public int Kontostand { get; set; }

        public void KontostandAnzeigen()
        {
            Console.WriteLine($"Kontoinhaber: {Inhaber} \nKontostand: {Kontostand}");
        }
        public void Einzahlen()
        {
            Kontostand += 50;
            Console.WriteLine($"Einzahlung erfolgt \nKontostand: {Kontostand}");

        }
    }
}
