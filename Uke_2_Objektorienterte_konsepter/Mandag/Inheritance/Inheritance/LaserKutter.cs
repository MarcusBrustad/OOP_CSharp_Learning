namespace Inheritance;
/*
Oppgave 2. 
Del 1. 
    - Lag en ny underklasse `LaserKutter` som også arver fra `Maskin`.
    - Legg til metode: `Kutt()` som skriver:
        > "Laser kutteren kutter materialet."  
 */

// Samme her, deklarerer klasse og setter den som en 'sub-class' av Maskin
public class LaserKutter : Maskin
{
    // Legg til metode: `Kutt()`
    public void Kutt()
    {
        // som skriver: - "Laser kutteren kutter materialet."
        Console.WriteLine("Laser kutteren kutter materialet.");
    }
}