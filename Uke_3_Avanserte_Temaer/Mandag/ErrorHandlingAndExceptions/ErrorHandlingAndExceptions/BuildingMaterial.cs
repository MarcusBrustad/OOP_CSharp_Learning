namespace ErrorHandlingAndExceptions;

/*
    💡 Ekstra utfordring (logisk og realistisk!)
        1. Lag en klasse `BuildingMaterial` med egenskapene `Name` og `StockLevel`.
        2. Lag en egen definert exception-klasse:
            'MaterialUsageException'
        3. Lag en metode `Use(int amount)` i `BuildingMaterial` som:
            - Trekker `amount` fra `StockLevel`.
            - Hvis `amount > StockLevel`, kast en `MaterialUsageException` uten melding (la standardmeldingen vises).
 */
public class BuildingMaterial
{
    public string Name { get; set; }
    public int StockLevel { get; set; }

    public void Use(int amount)
    {
        if (amount > StockLevel)
        {
            throw new MaterialUsageException();
        }
        StockLevel -= amount;
    }
    
}