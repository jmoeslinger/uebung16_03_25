namespace UebungSchueler;

public class Student
{
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public string Mainclass { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hallo, mein Name ist {Firstname} {Surname} und ich Schüler der {Mainclass}.");
    }

}