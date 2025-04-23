namespace ErrorHandlingAndExceptions;

class Program
{
    static void Main(string[] args)
    {
        //  Oppgave 1:
        Oppgave1();
        // Neste del:
        NextStep();
        
        // Oppgave 2:
        Oppgave2();
        // Neste del:
        NextStep();
        
        // EkstraOppgave
        EkstraOppgave();
        // Avslutt
        Avslutt();
    }

    
    
    //------------------------------------------------------------------------------------------------------------// 
    /*
    - 🧩 Oppgave 1: Enkle try/catch
        1. Lag et program som ber brukeren om å skrive inn et heltall.
        2. Bruk `try`/`catch` til å forsøke å parse tallet med `int.Parse()`.
        3. Hvis input ikke er gyldig, skriv ut en feilmelding:
            `"Ugyldig input. Du må skrive inn et heltall."`
    */
    public static void Oppgave1()
    {
        // ber om inputt, 
        Console.WriteLine("Vennligst skriv inn et heltall: ");
        var input = Console.ReadLine();
        // Prøver å parse (caste til int)
        try
        {
            int nummer = int.Parse(input);
            //int.TryParse(input, out var number); // en måte å gjøre dette.
        }
        // Fanger opp dersom det er feil format.
        catch (FormatException)
        {
            Console.WriteLine("Ugyldig input. Du må skrive inn et heltall.");
        }
        // Printer ut uansett og takker for innsatsen. 
        finally
        {
            Console.WriteLine("Takk for innsatsen!");
        }
    }
    
    
    //------------------------------------------------------------------------------------------------------------// 
    /*
    - 🔧 Oppgave 2: Bruk throw
        1. Lag en metode `Divide(int a, int b)` som returnerer `a / b`.
        2. Hvis `b == 0`, kast en `DivideByZeroException` manuelt med `throw`.
        3. Kall metoden inne i en `try`/`catch`blokk og håndter feilen med en klar melding.
     */

    public static void Oppgave2()
    {
        // Bruker metode for å loope til man får en gyldig int for nummer 1 og nr 2.
        int n1 = GetInt(1);
        int n2 = GetInt(2);

        // Bruker try catch med Metoden for å se etter om det gikk å dele eller om tall 2 == 0.
        try
        {
            Console.WriteLine($"Resultatet av å dele tallene dine ble: {Divide(n1, n2)}");
        }
        // Vet at vi kaster en DivideByZeroException så kan være explisitte her for ryddighetens skyld. 
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Takk for innsatsen!");
        }
    }

    // Metode som deler a og b. Returnerer som double hvis a er minst, og som int dersom b er minst.
    // Dersom b == 0 så kaster den exception. 
    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Kan ikke dele på null.");
        }
        
        return (double)a / b;
    }

    // Metode for å spørre igjen frem til den får en int.
    public static int GetInt(int nummer)
    {
        string? input;
        do
        {
            Console.WriteLine($"Vennligstt skriv heltall nr: {nummer}");
            input = Console.ReadLine();

        } while (!IsInt(input));
        return int.Parse(input);
    }

    // Metode for å validere om en string verdi er et tall.
    public static bool IsInt(string nummer)
    {
        return int.TryParse(nummer, out _);
    }
    
    
    //------------------------------------------------------------------------------------------------------------// 
    /*
    - 💡 Ekstra utfordring (logisk og realistisk!)
        De første delene her er i egne klasser. 
        4. I `Main()`:
            - Lag en `List<BuildingMaterial>` med noen materialer og lagernivå.
            - Bruk en løkke for å forsøke å bruke ulike mengder av hvert materiale.
            - Pakk `Use()`kallet i en `try/catch`.
        5. I `catch`, bruk `switch` eller `if`sjekk for å håndtere feilmeldinger:
            - Hvis `MaterialUsageException`: skriv ut `"Feil: {ex.Message}"`.
            - For andre exceptions: skriv ut `"Ukjent feil."`
     */

    public static void EkstraOppgave()
    {
        List<BuildingMaterial> materials = new List<BuildingMaterial>()
        {
            { new BuildingMaterial() { Name = "Steel", StockLevel = 5 } },
            { new BuildingMaterial() { Name = "Wood", StockLevel = 19}},
            { new BuildingMaterial() { Name = "Eplekake", StockLevel = 3}}
        };
        foreach (var material in materials)
        {
            try
            {
                material.Use(4);
            }
            catch (Exception e)
            {
                switch (e)
                {
                    case MaterialUsageException ex:
                        Console.WriteLine($"Feil: {ex.Message}");
                        break;
                    default:
                        Console.WriteLine("Ukjent feil.");
                        break;
                }
            }
            finally
            {
                Console.WriteLine($"{material.Name} stock after use: {material.StockLevel}");
            }
            
        }
    }
    
    
    
    //------------------------------------------------------------------------------------------------------------//      
    public static void NextStep()
    {
        Console.WriteLine("\nTrykk en knapp for neste steg");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Avslutt()
    {
        Console.WriteLine("\nTrykk en knapp for avslutting av program.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}