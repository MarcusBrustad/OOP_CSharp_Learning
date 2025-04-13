namespace VirtualMethods;

/*
🔧 Oppgave 2: Lag underklasser med override**
    1. Lag en klasse `Gravemaskin` som arver fra `Maskin` og **override** `Start()` til å skrive:
        > "Gravemaskinen brummer i gang!"
    2. Lag en klasse `Heisekran` som også arver fra `Maskin`, men **ikke** override metoden.
 */

// Klassen arver fra Maskin, og kan dermed bruke og override den virtuelle metoden fra klassen.
public class Gravemaskin : Maskin
{
    
    // Bruker override her for å overstyre hva som skjer i metoden i baseklassen. 
    // 'polymorphism', samme metode gjør forskjellige ting for forskjellige objekter/instanser
    public override void Start()
    {
        
        // Endrer print melding med å endre hva som skjer i metoden (her skriver ut til consoll). 
        Console.WriteLine("Gravemaskinen brummer i gang!");
    }
}