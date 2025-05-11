using System.Threading.Channels;

namespace Linq;

/*
- **🧩 Oppgave 1: Finn produkter under 100 kr**
    1. Lag en `Product`klasse med `Name` og `Price`.
    2. Lag en liste med minst 6 produkter, noen over og noen under 100 kr.
    3. Bruk `Where()` for å hente alle produktene under 100 kr.
    4. Skriv ut navnene på de som matcher.
- **🔧 Oppgave 2: Sorter produkter etter pris**
    1. Bruk `OrderBy()` for å sortere produktene etter pris.
    2. Bruk `Select()` for å hente bare navnene.
    3. Skriv ut navnene i sortert rekkefølge.
- **💡 Ekstra utfordring: Kombiner filter, sortering og prosjektering**
    1. Lag en `Book`klasse med `Title`, `Author`, og `Pages`.
    2. Lag en liste med minst 6 bøker.
    3. Bruk LINQ til å finne bøker over 200 sider, sortert etter tittel.
    4. Bruk `Select()` til å hente bare `"Title by Author"` som streng.
    5. Skriv ut resultatet med `foreach`.
 */

class Program
{
    static void Main(string[] args)
    {
        // Oppgave 1
        Oppgave1();
        NextStep();
        
        // Oppgave 2
        Oppgave2();
        NextStep();
        
        // Ekstra Oppgave
        EkstraOppgave();
        
        Avslutt();

    }

    
    //------------------------------------------------------------------------------------------------------------//
    private static void Oppgave1()
    {
        /*
        **🧩 Oppgave 1: Finn produkter under 100 kr**
            1. Lag en `Product`klasse med `Name` og `Price`.
            2. Lag en liste med minst 6 produkter, noen over og noen under 100 kr.
            3. Bruk `Where()` for å hente alle produktene under 100 kr.
            4. Skriv ut navnene på de som matcher.
            
            Noe er skrevet i egne metoder. 
         */
        List<Product> produkter = HentListeProdukter();
        Console.WriteLine("Alle produkter i original liste:");
        foreach (var produkt in produkter)
        {
            PrintProdukt(produkt);
        }
        
        Console.WriteLine();
        
        // 3. Bruk `Where()` for å hente alle produktene under 100 kr.
        var under100 = produkter.Where(p => p.Price < 100);
        // 4. Skriv ut navnene på de som matches.
        Console.WriteLine("Produkter som koster under 100:"); 
        foreach (var p in under100)
        {
            Console.WriteLine(p.Name);
        }
    }
    
    //------------------------------------------------------------------------------------------------------------//

    private static void Oppgave2()
    {
        /*
        **🔧 Oppgave 2: Sorter produkter etter pris**
            1. Bruk `OrderBy()` for å sortere produktene etter pris.
            2. Bruk `Select()` for å hente bare navnene.
            3. Skriv ut navnene i sortert rekkefølge.
         */
        var produkter = HentListeProdukter();
        Console.WriteLine("Alle produkter i original liste:");
        foreach (var produkt in produkter)
        {
            PrintProdukt(produkt);
        }
        Console.WriteLine();
        var sortert = produkter
            .OrderBy(p  => p.Price)
            .Select(p => p.Name);
        Console.WriteLine("Produkter sortert etter pris:\n");
        foreach (var p in sortert)
        {
            Console.WriteLine(p);
        }
    }

    //------------------------------------------------------------------------------------------------------------//

    private static void EkstraOppgave()
    {
        /*
        **💡 Ekstra utfordring: Kombiner filter, sortering og prosjektering**
            1. Lag en `Book`klasse med `Title`, `Author`, og `Pages`.
            2. Lag en liste med minst 6 bøker.
            3. Bruk LINQ til å finne bøker over 200 sider, sortert etter tittel.
            4. Bruk `Select()` til å hente bare `"Title by Author"` som streng.
            5. Skriv ut resultatet med `foreach`.
            
            Deler er i egne metoder.
         */

        var books = HentListeBooks();
        Console.WriteLine("Liste med Bøker: ");
        foreach (var book in books)
        {
            PrintBook(book);
        }

        Console.WriteLine();
        // 3. Bruk LINQ til å finne bøker over 200 sider, sortert etter tittel.
        // 4. Bruk `Select()` til å hente bare `"Title by Author"` som streng.
        var sortertOgOver200 = books
            .Where(b => b.Pages > 200)
            .OrderBy(b => b.Author)
            .Select(b => $"{b.Title} by {b.Author}");

        // 5. Skriv ut resultatet med `foreach`.
        Console.WriteLine("Bøker med over 200 sider, sortert etter forfatter skrevet ut med title og forfatter");
        foreach (var b in sortertOgOver200)
        {
            Console.WriteLine(b);
        }
    }

    //------------------------------------------------------------------------------------------------------------//
    private static List<Product> HentListeProdukter()
    {
        // 2. Lag en liste med minst 6 produkter, noen over og noen under 100 kr.
        return
        [
            new Product() { Name = "Sykkel", Price = 850 },
            new Product() { Name = "Bok", Price = 150 },
            new Product() { Name = "Vannflaske", Price = 25 },
            new Product() { Name = "Datamus", Price = 300 },
            new Product() { Name = "Kaffe", Price = 89 },
            new Product() { Name = "T-skjorte", Price = 199 },
            new Product() { Name = "Notatbok", Price = 45 },
            new Product() { Name = "Hodetelefoner", Price = 1200 },
            new Product() { Name = "Brød", Price = 35 },
            new Product() { Name = "Kinobillett", Price = 130 }
        ];
    }

    private static List<Book> HentListeBooks()
    {
        // 2. Lag en liste med minst 6 bøker.
        return
        [
            new Book() { Title = "Harry Potter og De vises stein", Author = "J.K. Rowling", Pages = 336 },
            new Book() { Title = "Ringenes herre: Eventyret om ringen", Author = "J.R.R. Tolkien", Pages = 423 },
            new Book() { Title = "1984", Author = "George Orwell", Pages = 328 },
            new Book() { Title = "The Metamorphosis", Author = "Franz Kafka", Pages = 143 },
            new Book() { Title = "Stolthet og fordom", Author = "Jane Austen", Pages = 432 },
            new Book() { Title = "Menn som hater kvinner", Author = "Stieg Larsson", Pages = 590 },
            new Book() { Title = "The Old Man and the Sea", Author = "Ernest Hemingway", Pages = 127 },
            new Book() { Title = "To Kill a Mockingbird", Author = "Harper Lee", Pages = 281 },
            new Book() { Title = "Fahrenheit 451", Author = "Ray Bradbury", Pages = 158 },
            new Book() { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Pages = 224 },
            new Book() { Title = "Little Women", Author = "Louisa May Alcott", Pages = 449 },
            new Book() { Title = "Of Mice and Men", Author = "John Steinbeck", Pages = 107 },
            new Book() { Title = "The Da Vinci Code", Author = "Dan Brown", Pages = 454 },
            new Book() { Title = "The Hunger Games", Author = "Suzanne Collins", Pages = 374 },
            new Book() { Title = "Animal Farm", Author = "George Orwell", Pages = 112 },
            
        ];
    }
    
    // Enkel metode for å printe info på produkter
    private static void PrintProdukt(Product produkter) => 
        Console.WriteLine($"Produkt: {produkter.Name} Price: {produkter.Price}"); 
    
    // Enkel metode for å printe info om bøker:
    private static void PrintBook(Book book) => 
        Console.WriteLine($"Book: {book.Title}, Author: {book.Author}, Pages: {book.Pages}");
    
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