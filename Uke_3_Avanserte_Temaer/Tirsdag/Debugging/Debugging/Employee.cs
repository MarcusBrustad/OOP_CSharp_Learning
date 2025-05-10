namespace Debugging;

/*
💡 Ekstra utfordring (multi-feil feilsøking)
            Et firma bruker et system for å regne ut lønn, men noe går galt…
            1. Lag en klasse `Employee` med `Name`, `HoursWorked`, `HourlyRate`.
            2. Lag en metode `CalculatePay()` som returnerer `HoursWorked + HourlyRate`.
                *(Hint: feil – noe galt med utregning?)*
 */
public class Employee
{
    public string? Name { get; set; }
    public int? HoursWorked { get; set; }
    public decimal? HourlyRate { get; set; } // decimal? etter fix for for å sikre at det kan være 0.


    // Metoden under er med feil utregning. 
    public decimal? CalculatePay()
    {
        return HoursWorked + HourlyRate; //Error, logisk. 
    }
    
    // Metoden under er etter fix, når man får feil på feilsøk. 
    // public decimal CalculatePay()
    // {
    //     return HoursWorked * HourlyRate;
    // }
    
}