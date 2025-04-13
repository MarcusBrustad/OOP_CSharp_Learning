namespace Polymorphism;

/*
1. Lag en `List<Maskin>` som inneholder begge maskinene.
2. Bruk en `foreach`løkke til å kalle `Start()` på hver maskin i listen.
3. Observer at riktig versjon av metoden kjøres for hvert objekt!
 */

/*
Ekstra:
    3. Legg `RobotArm` til i listen over maskiner og kjør igjen!
 */

class Program
{
    static void Main(string[] args)
    {
        // 1.
        List<Maskin> maskinene = new List<Maskin>()
        {
            new Printer3D(),
            new LaserKutter()
        };
        
        // 2. 
        Console.WriteLine("Hovedoppgaver: \n");
        foreach (Maskin maskin in maskinene)
        {
            maskin.Start();
        }
        
        //prompt og rydding av skjerm.
        NextStep();
        
        // Ekstra:
        RobotArm robotArm = new RobotArm();
        maskinene.Add(robotArm);

        foreach (Maskin maskin in maskinene)
        {
            maskin.Start();
        }
        
        // Prompt for å avslutte.
        Avslutt();
    }

    // Lager en metode for rydde i Main(). Når vi skal til neste steg. 
    public static void NextStep()
    {
        Console.WriteLine("\nTrykk en knapp for neste del.\n");
        Console.ReadKey();
        Console.Clear();
    }

    // Igjen for rydding, avslutter programmet etter knappetrykk
    public static void Avslutt()
    {
        Console.WriteLine("\nTrykk en knapp for å avslutte.");
        Console.ReadKey();
    }
}