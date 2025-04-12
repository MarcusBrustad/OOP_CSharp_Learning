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
        Console.WriteLine("\nTrykk på en knapp for å se neste del");
        Console.ReadKey(); //ReadKey for å beholde konsollen åpen slik at man kan se at det fungerer. 
        
        // Lag to Person-objekter med forskjellig info 
        // Kjør PresenterDeg() på begge 
        // Ingen looping, det kommer senere. 
        Person person1 = new Person();
        person1.Name = "Simon";
        person1.Age = 25;
        
        Person person2 = new Person();
        person2.Name = "Per";
        person2.Age = 30;
        
        person1.PresenterDeg();
        person2.PresenterDeg();

        Console.WriteLine("\nTrykk på en knapp for å se neste del");
        Console.ReadKey();
        
        // Eksperimenter med å skrive ut feltene direkte, uten metode – hva skjer?  
        Console.WriteLine(person1.Name, person1.Age); //Se hva som skjer hvis man skriver sånn. 
        // Console.WriteLine(person1.Name); // Fjern comment foran koden her for å se at det fungerer.
        // Console.WriteLine(person1.Age); // Fjern comment foran koden her for å se at det fungerer. 
        Console.WriteLine(person2.Name, person2.Age);

        Console.WriteLine("\nTrykk på en knapp for å avslutte. ");
        Console.ReadKey();
        
    }
}