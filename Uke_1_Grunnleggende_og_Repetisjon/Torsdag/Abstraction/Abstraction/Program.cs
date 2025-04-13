namespace Abstraction;

/*
2. I `Main()`:
    - Lag objekter av `Hammer` og `Skrujern`.
    - Kall `Bruk()` på begge objektene, så du ser beskrivelsen av bruken i konsollen.

Hvis du vil ta det ett hakk videre:
    - Lag en liste (`List<Verktoy>`) som inneholder begge verktøyene.
    - Bruk en `foreach`løkke til å gå gjennom listen og kalle `Bruk()` på hvert verktøy.
 */
class Program
{
    static void Main(string[] args)
    {
        // Lag objekter av `Hammer` og `Skrujern`.
        // Siden klassene ikke har noen fields eller properties trenger vi ikke gi de verdier, vi vil bare bruke
        // metodene som er i klassene (public override bruk) Eller her: Bruk()
        Hammer hammer = new Hammer(); 
        Skrujern skrujern = new Skrujern();
        
        // Kall `Bruk()` på begge objektene, så du ser beskrivelsen av bruken i konsollen.
        hammer.Bruk();
        skrujern.Bruk();

        Console.WriteLine("\nTrykk på en knapp for å gå til ekstra del.");
        
        Console.ReadKey(); //Igjen for å holde terminalen oppe. 
        Console.Write("\n\n"); // \n for ny linje for å rydde mer i konsollen før neste del. 
        
        
        // Lag en liste (`List<Verktoy>`) som inneholder begge verktøyene.
        // Siden begge verktøyklassene arver fra verktoy kan vi trygt lage en liste med verktoy her og bruke samme
        // metodekall på de. 
        List<Verktoy> verktoyKassen = new List<Verktoy>();
        verktoyKassen.Add(hammer);
        verktoyKassen.Add(skrujern);
        
        // Bruk en `foreach`løkke til å gå gjennom listen og kalle `Bruk()` på hvert verktøy.
        // denne loopen går gjennom hvert element i listen og gjør noe kode med den. 
        foreach (var verktoy in verktoyKassen)
        {
            // her bruker jeg bare litt kode for å vise hvilken type verktøy vi er på. 
            Console.WriteLine($"Dette verktøyet er: [{verktoy.GetType().Name}]");
            
            
            
            // bruker samme metode som begge arveklassene har, men se hva som er forskjellen. 
            // v---  Dette er looping gjennom
            verktoy.Bruk();
        }


        Console.WriteLine("Trykk på en knapp for å avslutte.");
        Console.ReadKey(); // Holder konsollen åpen.
        
        
    }
}