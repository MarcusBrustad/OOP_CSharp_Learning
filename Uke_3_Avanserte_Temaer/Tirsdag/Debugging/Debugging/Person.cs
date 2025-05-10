namespace Debugging;
/*
- **🧩 Oppgave 1: Finn den logiske feilen**
    1. Lag en klasse `Person` med `Name` og `Age`.
    2. Lag en metode `IsAdult()` som returnerer `true` hvis personen er 18 eller eldre.
    3. Feilen: metoden returnerer `Age <= 18` (feil retning!).
 */
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    
    
    // Metoden under er med feil, den over er riktig skrevet, denne ble brutk først for feiltesting. 
    // For debugging har jeg markert linjen som inneholder return Age <= 18, sammen med foreach i program filen. 
    public bool IsAdult()
    {
        return Age <= 18;
    }
    
    
    // Metoden under er etter retting når feilsøking er gjennomført. 
    // public bool IsAdult()
    // {
    //     return Age >= 18;
    // }
    
}