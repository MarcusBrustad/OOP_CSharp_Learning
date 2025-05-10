using System.Threading.Channels;

namespace Lambda;
/*
- **🧩 Oppgave 1: Fra delegate til lambda**
    1. Lag en `Func<int, int>` kalt `kvadrat` som returnerer tallet opphøyd i 2.
    2. Først lag den med `delegate`syntaks.
    3. Deretter omskriv den med lambda-syntaks.
    4. Test begge versjonene med `kvadrat(5)`.
- **🔧 Oppgave 2: Bruk `Action<>` med lambda**
    1. Lag en `Action<string>` kalt `printer`.
    2. Skriv den som en lambda som skriver ut `"Mottatt melding: <melding>"`.
    3. Kall `printer("Hei!")`.
- **💡 Ekstra utfordring: Bruk lambdas i metode**
    Tema: **Sortering og filtrering**
    1. Lag en klasse `Product` med `Name` og `Price`.
    2. Lag en liste med minst 5 produkter med ulik pris.
    3. Bruk `List<Product>.FindAll()` med en lambda for å finne produkter under 100 kr.
    4. Bruk `List<Product>.Sort()` med en lambda for å sortere etter pris.
    5. Bruk `Action<Product>` med lambda for å skrive ut produktene med `foreach`.
    
 */
class Program
{
    static void Main(string[] args)
    {
        // Første del
        Oppgave1();
        NextStep();
        
        //Andre del
        Oppgave2();
        NextStep();
        
        //Ekstra oppgave
        EkstraOppgave();
        Avslutt();

    }

    private static void Oppgave1()
    {
        // 1.1. Lag en `Func<int, int>` kalt `kvadrat` som returnerer tallet opphøyd i 2.
        // 1.2. Først lag den med `delegate`syntaks.
        Func<int, int> kvadrat = delegate(int x) { return x * x;};
        // 1.3. Deretter omskriv den med lambda-syntaks.
        Func<int, int> kvadrat2 = x => x * x;
        // 1.4. Test begge versjonene med `kvadrat(5)`.
        Console.WriteLine(kvadrat(5));
        Console.WriteLine(kvadrat2(5));
    }

    private static void Oppgave2()
    {
        // 1. Lag en `Action<string>` kalt `printer`.
        // 2. Skriv den som en lambda som skriver ut `"Mottatt melding: <melding>"`.
        Action<string> printer = melding => Console.WriteLine($"Mottat melding: <{melding}>");
        
        // 3. Kall `printer("Hei!")`.
        printer("Hei!");
    }

    private static void EkstraOppgave()
    {
        
        // 2. Lag en liste med minst 5 produkter med ulik pris.
        List<Product> products = new List<Product>()
        {
            new Product() { Name = "Pizza", Price = 100 },
            new Product() { Name = "Eple", Price = 11 },
            new Product() { Name = "Tannbørste", Price = 12 },
            new Product() { Name = "Kakao", Price = 50 },
            new Product() { Name = "Kake", Price = 105 },
            new Product() { Name = "Is", Price = 69 },
        };
        Console.WriteLine("Produkter i listen:");
        foreach (var product in products)
        {
            Console.WriteLine($"Produkt:  {product.Name}, pris: {product.Price}");
        }

        Console.WriteLine();
        
        // 3. Bruk `List<Product>.FindAll()` med en lambda for å finne produkter under 100 kr.
        var below100 = products.FindAll(x => x.Price < 100);
        Console.WriteLine("Produkter fra listen med pris under 100;");
        foreach (var item in below100)
        {
            Console.WriteLine($"Produkt: {item.Name} Pris: {item.Price}");
        }

        Console.WriteLine();
        // 4. Bruk `List<Product>.Sort()` med en lambda for å sortere etter pris.
        products.Sort((a, b) => a.Price.CompareTo(b.Price));
        Console.WriteLine("Produkter sortert etter pris");
        foreach (var it in products)
        {
            Console.WriteLine($"Produkt: {it.Name} pris: {it.Price}.");
        }

        Console.WriteLine();
        // 5. Bruk `Action<Product>` med lambda for å skrive ut produktene med `foreach`.
        Console.WriteLine("Test av print med lambda");
        Action<Product> skrivUtProdukt = p => Console.WriteLine($"Produkt: {p.Name} pris: {p.Price}.");
        foreach (var prdkt in products)
        {
            skrivUtProdukt(prdkt);
        }
        
    }
    
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