namespace Sealed;

/*
2. Lag en underklasse `Hammer` som override`r` `Use()` og skriver:
    - `"Hammering the wood."`
 */

/*
4. Gjør Hammer til en sealed klasse og observer hva som skjer!
 */
// Arveklasse Hammer som arver fra Tool
sealed class Hammer : Tool
{
    // Bruker override på virtual metoden i Tool
    public override void Use()
    {
        // bruker polymorphism til å overskrive hva som skjer nå man kaller Use()
        Console.WriteLine("Hammering the wood");
    }
}