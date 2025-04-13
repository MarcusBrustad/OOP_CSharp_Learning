namespace Abstraction;

/*
- 🔧 **Oppgave 2: Flere verktøy**
    1. Lag en klasse `Skrujern` som også arver fra `Verktoy`, og implementer `Bruk()` slik at den skriver ut:
        "Jeg bruker skrujernet til å skru skruer."
 */
// Arver på samme måte som Hammer gjør fra Verktoy og implementerer de samme elemente, men på forskjellige måter. 
public class Skrujern  : Verktoy
{
    // Samme metode som i baseklassen og hammer, men annen utskfrift til konsollen. 
    // Override her lar oss igjen endre hva som skjer i metoden. 
    public override void Bruk()
    {
        Console.WriteLine("Jeg bruker skrujernet til å skru skruer.");
    }
}