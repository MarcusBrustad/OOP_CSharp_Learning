namespace Interfaces;
/*
2. Lag en klasse `Hammer` som implementerer `ITool`.
    - I `Use()`, skriv: `"Hammering the wood."`
 */

// Lager klassen, setter også at det er av typen ITool interfacet. PS. Se at det deklareres på samme måte som arv.
public class Hammer : ITool
{
    // Implementerer delene fra interfacet (krav om å være mec)
    public void Use()
    {
        Console.WriteLine("Hammering the wood");
    }
}