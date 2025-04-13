namespace Sealed;

/*
- 🧩 Oppgave 1: Forstå sealed klasser
    1. Lag en baseklasse `Tool` med en virtual metode `Use()`.
 */
// Lager original baseklasse
public class Tool
{
    // med en virtual metode `Use()`.
    public virtual void Use()
    {
        Console.WriteLine("The tool is working");
    }
}