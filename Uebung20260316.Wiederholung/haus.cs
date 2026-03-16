namespace Uebung20260316.Wiederholung
{
    public class Haus
    {
        private double _qm = 150;
        public Haus(double qm, string _farbe)
        { 
        
            _qm = qm;   
            Farbe= _farbe;
        }

        public string Farbe { get; private set; } = "weiß";

        public void Anstreichen(string _farbe)
        {
            if (_farbe != "pink")

                    Farbe = _farbe;
        }
        public double Quadratmeter
        {
            get { return _qm; }
            set
            {
                if (value > 50)
                {
                    _qm = value;
                }
            }
        }

    }
}
