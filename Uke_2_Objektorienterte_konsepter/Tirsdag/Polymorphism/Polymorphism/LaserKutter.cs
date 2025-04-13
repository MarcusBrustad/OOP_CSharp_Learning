namespace Polymorphism;
/*
- `LaserKutter`: override `Start()` til å skrive:
    > "Laserkutteren kutter materialet."
 */
// Arver fra Maskin
public class LaserKutter : Maskin
{
    // Bruker 'override' for å endre metoden fra baseklassen (polymophism)
    public override void Start()
    {
        // Ny tekst her (polymoprhism)
        Console.WriteLine("Laserkutteren kutter materialet.");
    }
}