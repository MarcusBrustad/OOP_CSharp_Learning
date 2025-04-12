namespace Encapsulation;

/*
 * Oppgave 2: Kontroller tilgang
    1. Legg inn en enkel sjekk i `set` på `Alder` slik at:
        - Hvis noen prøver å sette alder til et negativt tall, skriv ut en feilmelding i konsollen.
    ^--^--- Er begge gjort i "Person.cs"
    2. Test dette ved å sette alder til -5 og se hva som skjer.
 */
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person()
        {
            Name = "John",
            Age = -3
        };
        
        person1.PresenterDeg(); // Henter ut personen (instansen med melding) og vi ser at alder har 0 i verdi. 
        Console.ReadKey(); // For å holde terminalen oppe.
    }
}