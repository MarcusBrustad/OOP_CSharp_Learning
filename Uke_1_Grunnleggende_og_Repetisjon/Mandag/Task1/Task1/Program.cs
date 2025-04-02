// 1: Lag en ny C#-fil og skriv en klasse i et eget namespace.
// 2: Skriv ut "Hei fra [Ditt navn]" i konsollen ved hjelp av Console.WriteLine();.

namespace Task1;
// Når man ikke bruker automatisk "Globad using" så må using System være i namespace
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hei fra Marcus!");
    }
}