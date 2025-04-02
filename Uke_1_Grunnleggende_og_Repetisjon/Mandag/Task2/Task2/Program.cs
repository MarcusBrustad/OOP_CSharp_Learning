namespace Task2;

// using System; -- Denne er kommentert ut. 

//- Prøv å fjerne `using System;` fra toppen og skriv hele stien til `Console.WriteLine()` manuelt.
// - Hva skjer, og hvorfor er dette upraktisk?
//      - Må bruke "System.Console.Writeline", altså kalle på System hver gang jeg skal bruke systemfunksjoner. 

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hilsen fra Marcus!");
    }
}