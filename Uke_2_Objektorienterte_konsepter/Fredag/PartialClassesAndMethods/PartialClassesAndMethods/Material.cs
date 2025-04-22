namespace PartialClassesAndMethods;

/*
1. Lag en `partial class` kalt `Material`.
2. Del den opp i to filer:
    - I første del: Legg til egenskapene `string Name` og `double Quantity`.
    - I andre del: Lag metoden `Describe()` som skriver:
        - `$"{Name}: {Quantity} units in stock."`
 */
// Partial keyword her for å lage første del av en partial klass. 
public partial class Material
{
    // I første del: Legg til egenskapene `string Name` og `double Quantity`.
    public string Name { get; set; }
    public double Quantity { get; set; }

    
    /*
    3. Implementer `OnUpdate()` i en annen fil, og la den skrive:
        - `"Updating material stock..."`
     */
    // Her implementeres den partial-metoden OnUpdate(), slik at den kan brukes av klassen. 
    public partial void OnUpdate()
    {
        Console.WriteLine("Updating material stock...");
    }
}