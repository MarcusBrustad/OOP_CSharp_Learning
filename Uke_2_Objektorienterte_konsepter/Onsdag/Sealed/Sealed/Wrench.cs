namespace Sealed;

/*
- 🔧 Oppgave 2: Test sealed metoder
    1. Lag en ny underklasse `Wrench` som arver fra `Tool`.
    2. Override `Use()` i `Wrench` og skriv:
    - `"Tightening bolts."`
 */
// Denne klassen arver fra Tool som ikke er 'sealed' og dermed er åpen for arv. 
public class Wrench : Tool
{
    // override 'Use()' - Polymoprhism // Første utkast er ikke sealed her, og kan dermed arves.
    // Etter steg 4 i oppgave 2 vil denne metoden bli sealed her. Dette påvirker ikke baseklassen, men alle som arver 
    // fra denne klassen igjen. 
    public sealed override void Use()
    {
        // Overstyrer metoden fra 'Tool' til å nå si "Tightening bolts."
        Console.WriteLine("Tightening bolts.");
    }
}