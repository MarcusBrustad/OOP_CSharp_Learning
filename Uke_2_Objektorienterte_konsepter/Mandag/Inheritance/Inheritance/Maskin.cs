namespace Inheritance;
/*
1. Lag en baseklasse `Maskin` med:
    - Egenskap: `string Navn`
    - Metode: `Start()` som skriver:      
        > "Maskinen starter."
 */

// Deklarerer en baseklasse som heter Maskin
public class Maskin
{
    // - Egenskap: `string Navn` - Property her med en get og set
    public string Navn { get; set; }
    
    // Metode: `Start()`
    public void Start()
    {
        // som skriver: - "Maskinen starter."
        Console.WriteLine("Maskinen starter.");
    }
    
}