namespace Debugging;

class Program
{
    static void Main(string[] args)
    {
        // Oppgave 1.
        Oppgave1();
        
        NextStep();
        
        // Oppgave 2.
        Oppgave2();
        
        NextStep();
        
        // Ekstra oppgave.
        EkstraOppgave();
        
        Avslutt();
    }

    public static void Oppgave1()
    {
        //  Oppgave 1:
        //      4. Lag en liste med personer og sjekk `IsAdult()` i en løkke.
        //      5. Bruk **breakpoints** og **stegvis kjøring** for å finne og rette logikken.
        List<Person> people = new List<Person>()
        {
            new Person() { Name = "John", Age = 20 },
            new Person() { Name = "Jane", Age = 19 },
            new Person() { Name = "David", Age = 5 },
            new Person() { Name = "Scott", Age = 7 },
        };

        // Plasserer breakpoint på foreach loop linjen, og et til inne på return i Person metoden. 
        // Bruker så "step into" - for å gå inn i metoder og ikke bare utføre de. Så bruker jeg step over videre for å 
        // se resultat og hva print out er. 
        foreach (var person in people)
        {
            Console.WriteLine(person.IsAdult());
        }
    }

    
    
    //------------------------------------------------------------------------------------------------------------//
    public static void Oppgave2()
    {
        /*
         -  🔧 Oppgave 2: Null-feil og inspeksjon**
                1. Lag en klasse `Vehicle` med `string Type`.
                2. Lag en metode `PrintType()` som skriver ut `Type.ToUpper()`.
                3. I `Main()`, legg til én `Vehicle` som ikke har `Type` satt (`null`).
                4. Kjør og se at du får en `NullReferenceException`.
                5. Bruk debuggeren til å:
                    - Finne **nøyaktig hvor** feilen skjer.
                    - Se innholdet i `Type`feltet.
                    - Fikse feilen på en god måte (f.eks. `if (Type != null)`)
         */
        
        
        Vehicle errorVehicle = new Vehicle();
        
        // Bruker breakpoint på linjen under. Kan være en ide å kommentere ute "Oppgave1();" i main for lettere debug.
        errorVehicle.PrintType();
    }
    
    
    
    //------------------------------------------------------------------------------------------------------------//

    public static void EkstraOppgave()
    {
        /*
        -💡 Ekstra utfordring (multi-feil feilsøking)
            Et firma bruker et system for å regne ut lønn, men noe går galt…
            1. Lag en klasse `Employee` med `Name`, `HoursWorked`, `HourlyRate`.
            2. Lag en metode `CalculatePay()` som returnerer `HoursWorked + HourlyRate`.
                *(Hint: feil – noe galt med utregning?)*
            3. Legg til en `Employee` som har `HourlyRate = 0` ved en feil i neste steg .
            4. Lag en liste med ansatte og skriv ut lønn.
            5. Bruk breakpoints, inspeksjon og stepping for å:
                - Oppdage begge feilene
                - Fikse feil i logikk
                - Validere input (f.eks. sjekk at `HourlyRate > 0`)
         */

        List<Employee> employees = new List<Employee>()
        {
            { new Employee() { Name = "John", HourlyRate = 250, HoursWorked = 10 } },
            { new Employee() { Name = "Cena", HourlyRate = 240, HoursWorked = 50 } },
            { new Employee() { Name = "Casper", HourlyRate = 300, HoursWorked = 25 } },
            { new Employee() { Name = "Yuna", HourlyRate = 1000, HoursWorked = 250 } },
            { new Employee() { Name = "Marcus", HourlyRate = 0, HoursWorked = 76 } }, // Error
        };

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} - Pay at this moment: {employee.CalculatePay()}");
        }

    }
    
    //------------------------------------------------------------------------------------------------------------//

    
    public static void NextStep()
    {
        Console.WriteLine("Trykk en knapp for neste steg");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Avslutt()
    {
        Console.WriteLine("Trykk en knapp for avslutting av program.");
        Console.ReadKey();
      
        Environment.Exit(0);
    }
    
}