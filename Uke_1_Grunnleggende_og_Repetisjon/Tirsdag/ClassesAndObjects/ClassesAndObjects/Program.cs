namespace ClassesAndObjects;

/*
I Main(): Lag et Person-objekt og kall metoden
👉 Husk å teste at alt fungerer. Bruk gjerne Console.ReadKey(); på slutten så konsollen holder seg åpen.


 Oppgave 2: Flere objekter
Lag to Person-objekter med forskjellig info
Kjør PresenterDeg() på begge
Eksperimenter med å skrive ut feltene direkte, uten metode – hva skjer?
 */
class Program
{
    static void Main(string[] args)
    {
        // Oppgave 1. 
        // Det er ingen konstruktør i Person klassen så må manuelt sette verdier som gjort under.
        // Kunne også brukt : personEn.Name = "Marcus"; personEn.Age = 27;
        Person personEn = new Person()
        {
            Name = "Marcus",
            Age = 27
        };

        personEn.PresenterDeg();
        Console.ReadKey(); //ReadKey for å beholde konsollen åpen slik at man kan se at det fungerer. 
        
    }
}