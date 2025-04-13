namespace Inheritance;

/*
2. Lag en underklasse `Printer3D` som arver fra `Maskin`.
    - Legg til en egen metode: `SkrivUt()` som skriver:        
        > "3D-printeren skriver ut et nytt objekt!"
 */

// Deklarerer klassen og viser at den arver fra BaseKlassen Maskin
public class Printer3D : Maskin
{
    // Legger ikke inn noen properties her, da det ligger i baseklassen, og vi ikke trenger noen andre detaljer for nå.
    
    // Legg til en egen metode: `SkrivUt()
    public void SkrivUt()
    {
        // som skriver: - "3D-printeren skriver ut et nytt objekt!"
        Console.WriteLine("3D-printeren skriver ut et nytt objekt!");
    }
}