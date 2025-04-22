namespace PartialClassesAndMethods;
/*
- 💡 Ekstra utfordring (med variasjon og logikk!)
    1. Lag en liste av ulike `Material`objekter med forskjellige `Quantity`verdier.
    2. Lag en metode `RestockIfLow()` som:
        - Går gjennom listen,
        - Bruker `if` for å sjekke om `Quantity < 10`,
        - Og da kaller `UpdateStock()` med en økning på f.eks. 20.
    3. Bonus: Bruk en `switch` for å gi ulik melding basert på materialets `Name`.
 */
// I denne oppgaven har jeg ryddet koden ved å gjøre delene i egne metoder, slik at metodekall lager lister og utfører
// oppgaver, da holder main seg ryddigere. 
class Program
{
    static void Main(string[] args)
    {
        // henter en liste med materialer
        List<Material> materials = GetMaterialsList();
        
        // Kjører metode for å sjekke mengde og evt. restocke. 
        RestockIfLow(materials);
    }
    
    
    
    //------------------------------------------------------------------------------------------------------------//      
    
    // For å gjøre hoveddelen ryddigere har jeg gjort delene i metoder.
    // Denne metoden lager og returnerer en liste med materialer. Og en random stock value opp til 20.
    public static List<Material> GetMaterialsList()
    {
        Random rnd = new Random();
        List<Material> materials = new List<Material>();
        materials.Add(new Material() { Name = "Steel", Quantity = rnd.NextInt64(15)});
        materials.Add(new Material() { Name = "Plastic", Quantity = rnd.NextInt64(10)});
        materials.Add(new Material() { Name = "Wood", Quantity = rnd.NextInt64(8)});
        materials.Add(new Material() { Name = "Oil", Quantity = rnd.NextInt64(20)});
        
        return materials;
    }
    
    //------------------------------------------------------------------------------------------------------------//      
    public static void RestockIfLow(List<Material> materials)
    {
        // Går gjennom alle materialene en etter en fra listen. 
        foreach (Material material in materials)
        {
            //Console.WriteLine($"{material.Name} har {material.Quantity} i stock før evt restock."); 
            // ^--Denne linjen legges inn (fjerne // foran) for å se stock først.
            
            // Bruker metoden for å sjekke om stock er under 10 for å gå videre.
            if (CheckQuantity(material))
            {
                // Dersom den er under 10 vil den første bruke switch metoden for å printe ut hva som restockes.
                PrintMaterialMessage(material);
                // Etter meldingen fra stock, vil den utføre restocking av materialet. 
                material.UpdateStock(20);
            }
            else
            {
                Console.WriteLine($"{material.Name} has high enough stock. No need for refill..");
            }

            //Console.WriteLine($"{material.Name} har {material.Quantity} i stock etter evt restock.\n"); 
            // ^--Denne linjen kan legges inn også dersom man vil se stock ette at koden har kjørt for oppdatert stock.
        }
    }
    
    

    // Denne metoden tar et material inn og sjekker om quantity er lavere enn 10, hvis det er det returnere den true,
    // hvis ikke returnere den false. 
    public static bool CheckQuantity(Material material)
    {
        return material.Quantity <= 10;
    }
    
    
    
    //------------------------------------------------------------------------------------------------------------// 
    
    /*
     * Bonus: Bruk en switch for å gi ulik melding basert på materialets Name.
     */

    // Dette er en metode som tar inn et materiale og bruker propertien Name for å switche.
    public static void PrintMaterialMessage(Material material)
    {
        // Bytter hendelse basert på Name   
        switch (material.Name)
        {
            // Steel har egen.
            case "Steel":
                Console.WriteLine("Restocking Steel");
                break;
            // Plastic har egen
            case "Plastic":
                Console.WriteLine("Restocking Plastic");
                break;
            // Dersom ingen av de over stemmer vil den bruke default. Og bruker her navnet på materialet for å printe.
            default:
                Console.WriteLine($"Restocking {material.Name}");
                break;
        }
    }
    //------------------------------------------------------------------------------------------------------------//      
    
    
    public static void NextStep()
    {
        Console.WriteLine("Trykk en knapp for neste steg");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Avslutt()
    {
        Console.WriteLine("Trykk en knapp for avslutting av program.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}