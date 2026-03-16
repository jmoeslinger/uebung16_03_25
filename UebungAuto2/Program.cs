
using System;

public class Auto
{
    public string Marke { get; set; } = "Audi";
    public string Modell { get; set; } = "A4";
    public int Baujahr { get; set; } = 2020;

    public void InfoAusgeben()
    {
        Console.WriteLine($"Marke: {Marke}");
        Console.WriteLine($"Modell: {Modell}");
        Console.WriteLine($"Baujahr: {Baujahr}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Auto auto1 = new Auto();
        auto1.Marke = "Audi";
        auto1.Modell = "A4";
        auto1.Baujahr = 2020;

        auto1.InfoAusgeben();

    }
}
