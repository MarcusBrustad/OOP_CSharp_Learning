namespace Inheritance;

/*
Oppgave 1. Del 3. 
    - I `Main()`:
        - Lag et objekt av `Printer3D` .
        - Sett `Navn` til "Ultimaker".
        - Kall `Start()` og `SkrivUt()` på objektet.

Oppgave 2. Del 2.
    - I 'Main'():
        - 2. Lag et objekt av `LaserKutter`.
        - Sett `Navn` til "Glowforge".
        - Kall `Start()` og `Kutt()` på objektet.
 */

class Program
{
    static void Main(string[] args)
    {
        //Lag et objekt av `Printer3D` .
        // - Sett `Navn` til "Ultimaker".
        Printer3D printer = new Printer3D()
        {
            Navn = "Ultimaker"
        };
        // Kall `Start()` og `SkrivUt()` på objektet.
        printer.Start();
        printer.SkrivUt();
        
        // Neste del i konsollen. 
        Console.WriteLine("\nTrykk en knapp for neste del. ");
        Console.ReadKey();
        Console.Clear();
        
        // Oppgave 2.
        // - Lag et objekt av `LaserKutter`.
        // - Sett `Navn` til "Glowforge".
        LaserKutter laser = new LaserKutter()
        {
            Navn = "Glowforge"
        };
        laser.Start();
        laser.Kutt();
        
        
        // For å avslutte. 
        Console.WriteLine("\nTrykk en knapp for å avslutte.");
        Console.ReadKey();
    }
}