namespace PartialClassesAndMethods;

/*
1. Lag en `partial class` kalt `Material`.
2. Del den opp i to filer:
    - I første del: Legg til egenskapene `string Name` og `double Quantity`.
    - I andre del: Lag metoden `Describe()` som skriver:
        - `$"{Name}: {Quantity} units in stock."`
 */

// Partial her fordi dette også er en del av samme klasse. 
public partial class Material
{
    // I andre del: Lag metoden `Describe()` som skriver:
    //   - `$"{Name}: {Quantity} units in stock."`

    public void Describe()
    {
        // Her bruker den egenskaper fra den andre delen. Så selv om det ikke ligger noen egenskaper direkte i klassen
        // vi ser her. Dette går siden den ligger i den andre delen av partial-klassen. 
        Console.WriteLine($"{Name}: {Quantity} in stock.");
    }
/*
- 🔧 Oppgave 2: Bruk partial metoder
    1. I `Material`, lag metoden `UpdateStock(double amount)`.
    2. Inne i `UpdateStock()`, kall en `partial void` metode `OnUpdate()` før du oppdaterer verdien.
    3. Implementer `OnUpdate()` i en annen fil, og la den skrive:
        - `"Updating material stock..."`
 */

    // Her lages metoden UpdateStock
    public void UpdateStock(double amount)
    {
        // Kaller på en partial metode her - den syntes under men har ikke noe kode, det utføres i den andre filen. 
        OnUpdate();
        Quantity += amount;
    }
    
    // Her her deklareres den partial'e metoden. 
    public partial void OnUpdate();
}