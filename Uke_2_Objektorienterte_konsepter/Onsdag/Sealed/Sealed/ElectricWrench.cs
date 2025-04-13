namespace Sealed;

/*
3. Lag en ny klasse `ElectricWrench` som arver fra `Wrench`.
4. Gjør `Use()` i `Wrench` til `sealed` og se hva som skjer når du prøver å override metoden i `ElectricWrench`.
 */
// Ny klasse som arver fra Wrench, dette går fint da Wrench klassen ikke er sealed. 
public class ElectricWrench : Wrench
{
    // // Første utkast her går fint. - Etter steg 4 vil det ikke fungere. 
    // public override void Use() // Etter sealing i Wrench fungerer det ikke lenger å override her.
    // {
    //     Console.WriteLine("Tightening bolts electricly.");
    // }
}