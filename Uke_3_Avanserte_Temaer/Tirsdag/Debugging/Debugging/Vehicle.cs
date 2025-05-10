namespace Debugging;

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
// Lager Vehicle klassen her. 
public class Vehicle
{
    public string? Type { get; set; }   // Etter fiksing og sjekk om "null" i fikset metode er det lurt å legge til: 
                                        // string? istedenfor bare string  


    // Metoden under er med feil. Bruker breakpoint på CW for å se error ved print. 
    // public void PrintType()
    // {
    //     Console.WriteLine(Type.ToUpper());
    // }
    
    // Metode under er etter en fix på NullReferanceException. BreakPoint lagt på CW med ToUpper()
    public void PrintType()
    {
        if (Type != null)
        {
            Console.WriteLine(Type.ToUpper());
        }
        else
        {
            Console.WriteLine("No Type set.");
        }
    }
}