namespace VirtualMethods;
/*
🧩 Oppgave 1: Lag en baseklasse med virtual metode**
    1. Lag en klasse `Maskin` med en virtuell metode `Start()`.
    2. `Start()`metoden skal skrive ut:
        > "Maskinen starter på vanlig måte."
*/

// Deklarerer klassen her. Vanlig public class. 
public class Maskin 
{
    
    // 1. Lag en klasse `Maskin` med en virtuell metode `Start()`.
    public virtual void Start()
    {
        
        // 2. `Start()`metoden skal skrive ut:"Maskinen starter på vanlig måte."
        Console.WriteLine("Maskinen starter på vanlig måte.");
        
    }
    
}