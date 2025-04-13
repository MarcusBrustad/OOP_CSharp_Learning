namespace Polymorphism;

/*
2. Lag to underklasser:
    - `Printer3D`: override `Start()` til å skrive:   
        > "3D-printeren starter produksjonen.
 */
// Arver fra Maskin
public class Printer3D  : Maskin
{
    // Bruker 'override' som gjør at samme metode som baseklassen kan brukes men gjør noe annerledes.
    public override void Start()
    {
        // Ny tekst: - "3D-printeren starter produksjonen."
        Console.WriteLine("3D-printeren starter produksjonen.");
    }
}