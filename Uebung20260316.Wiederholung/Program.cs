using Uebung20260316.Wiederholung;

Console.WriteLine("Hello, World!");

Haus h1 = new Haus(350, "blau");

Console.WriteLine($"Das Haus hat {h1.Quadratmeter} m2.");
h1.Anstreichen("rot");
Console.WriteLine($"Das Haus ist {h1.Farbe}.");