namespace Interfaces;
/*
3. Lag en klasse `Screwdriver` som implementerer `ITool`.
    - I `Use()`, skriv: `"Turning screws."`
 */

// Lager klassen, setter også at det er av typen ITool interface. PS. Se at det deklareres på samme måte som arv.
public class Screwdriver : ITool
{
    // Implementerer delene av Arven som må inkluderes.
    public void Use()
    {
        Console.WriteLine("Turning screws.");
    }
}