namespace Encapsulation;
/*
Oppgave 1: Forbedre din `Person`-klasse
    1. Endre feltene dine til `private`.
    2. Lag public egenskaper (`Navn`, `Alder`) som gir kontrollert tilgang til feltene.
    3. Bruk `PresenterDeg()` for å skrive ut informasjon om personen
    
- Oppgave 2: Kontroller tilgang
    1. Legg inn en enkel sjekk i `set` på `Alder` slik at:
        - Hvis noen prøver å sette alder til et negativt tall, skriv ut en feilmelding i konsollen.
 */
public class Person
{
    // 1. private field
    private string _name; //standard naming practice fra Rider og i C# er _litenBokstavFørst
    private int _age; //samme standard her. 
    
    // 2. Public egenskaper.
    public string Name //Standard naming for properties (public) er StorBokstavFørstOgForHvertord
    {
        get { return _name; } //get Name her henter ut verdien i det private field'et _name
        set { _name = value; } // set her gir en verdi til det private field'et _name
    }
    public int Age 
    {
        get { return _age; }
        set
        {
            // validering her. 
            if (value < 0)
            {
                // beskjed om feil
                Console.WriteLine("Alder under 0 er ikke tillat");
            }
            else
            {
                // Dersom en gyldig verdi er gitt, blir verdien satt til field'en
                _age = value;
            }
        }
    }

    public void PresenterDeg()
    {
        Console.WriteLine($"Hei! Mitt navn er {Name} og jeg er {Age} år gammel! Hyggelig å møte deg!"); 
        // bruker public properties for verdiene her. 
    }
    
}