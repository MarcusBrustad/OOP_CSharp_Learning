namespace Sealed;

/*
- 💡 Ekstra utfordring (anbefales!)
    1. Lag en helt ny `sealed class` kalt `Drill`.
    2. Legg til en metode `Use()` som skriver:
        - `"Drilling holes."`
 */
// En baseklasse som er sealed (altså kanskje ikke en baseklasse, men bare en klasse?)
sealed class Drill
{
    // 2. Legg til en metode `Use()`
    public void Use()
    {
        // som skriver: - "Drilling holes."`
        Console.WriteLine("Drilling holes.");
    }
}