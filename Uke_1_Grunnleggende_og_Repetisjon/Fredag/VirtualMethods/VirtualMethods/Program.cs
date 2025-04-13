namespace VirtualMethods;

/*
3. I `Main()`:
    - Lag objekter av `Gravemaskin` og `Heisekran`.
    - Kall `Start()` på begge og se forskjellen!
 */
class Program
{
    static void Main(string[] args)
    {
        // - Lag objekter av `Gravemaskin` og `Heisekran`.
        Gravemaskin gravemaskin = new Gravemaskin();
        Heisekran heisekran = new Heisekran();
        
        // Kall `Start()` på begge og se forskjellen!
        gravemaskin.Start();
        heisekran.Start();
        
        // splitting før neste del. 
        Console.WriteLine("\nTrykk på en knapp for å gå til neste del.");
        Console.ReadKey();
        
        // Ekstra utfordring:
        List<Maskin> maskinene = new List<Maskin>();
        maskinene.Add(gravemaskin);
        maskinene.Add(heisekran);
        // loop gjennom og kjør start.
        foreach (Maskin maskin in maskinene)
        {
            Console.WriteLine($"\nVi starter typen maskin: [{maskin.GetType().Name}] og");
            maskin.Start();
        }
        
        // ReadKey for å holde terminalen åpen. 
        Console.WriteLine("\nTrykk på en knapp for å avslutte.");
        Console.ReadKey();
    }
}