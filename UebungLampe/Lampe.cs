namespace UebungLampe
{
    public class Lampe
    {
        public string Farbe { get; set; }
        public bool istAn { get; set; }


        public void Einschalten()
        {
            istAn = true;
        }

        public void Ausschalten()
        {
            istAn = false;
        }

        public void StatusAnzeigen()
        {
            if (istAn)
            {
                Console.WriteLine($"Die Lampe ist an und hat die Farbe {Farbe}.");
            }
            else
            {
                Console.WriteLine("Die Lampe ist aus und hat die Farbe {Farbe}.");
            }
        }
    }
}