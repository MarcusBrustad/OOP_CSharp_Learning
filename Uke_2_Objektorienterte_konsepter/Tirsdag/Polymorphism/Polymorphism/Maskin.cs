namespace Polymorphism;
/*
Bruk klassen Maskin med en virtual metode Start().
 */

public class Maskin
{
    // Virtual for å kunne override.
    public virtual void Start()
    {
        Console.WriteLine("Maskinen Start");
    }
}