namespace Interfaces;
/*
- Oppgave 2: Lag en liste av tools
    1. I `Main()`, lag en `List<ITool>` og legg til både `Hammer` og `Screwdriver`.
    2. Bruk en `foreach`løkke til å kalle `Use()` på hvert element i listen.
 */

class Program
{
    static void Main(string[] args)
    {
        List<ITool> tools = new List<ITool>();
        tools.Add(new Hammer());
        tools.Add(new Screwdriver());

        foreach (var tool in tools)
        {
            Console.WriteLine($"The {tool.GetType().Name} is: ");
            tool.Use();
            Console.WriteLine("");
        }

        Avslutt();
        
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