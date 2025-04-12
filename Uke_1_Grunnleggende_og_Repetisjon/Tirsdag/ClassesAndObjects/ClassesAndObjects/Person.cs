namespace ClassesAndObjects;

/*
Lag Person.cs og implementer:

Feltene: Navn, Alder (helst som egenskaper)
Metoden: PresenterDeg() – skriv ut en hyggelig presentasjon
 */

public class Person
{
    // begge propertiene er public for å kunne påvirkes utenfor klassen.
    public string Name { get; set; } //Property for navn { get; set; } for å kunne sette og hente verdi. 
    public int Age { get; set; } //Property for alder { get; set; } for å kunne sette og hente verdi.

    public void PresenterDeg()
    {
        Console.WriteLine($"Hei, mitt navn er {Name} og jeg er {Age} år! Hyggelig å møte deg.");
    }
}