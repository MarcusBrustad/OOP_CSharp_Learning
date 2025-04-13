namespace Abstraction;
/*
2. Lag en klasse `Hammer` som arver fra `Verktoy`, og implementer `Bruk()` slik at den skriver ut:
    "Jeg bruker hammeren til å slå inn spiker."
 */
// Lager en public class Hammer og lar den arve fra Verktoy med : Verktoy
public class Hammer : Verktoy
{
    // Denne metoden må være med siden den er i baseklassen (abstrakte klassen).
    // Siden den skal bruke den samme metoden, men annerledes enn hva som er i baseklassen bruker vi "override" 
    public override void Bruk()
    {
        Console.WriteLine("Jeg bruker hammeren til å slå inn spikeren.");
    }
}