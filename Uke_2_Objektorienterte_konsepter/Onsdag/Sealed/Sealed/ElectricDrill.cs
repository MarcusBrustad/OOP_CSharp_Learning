namespace Sealed;

/*
3. Prøv å lage en klasse `ElectricDrill` som forsøker å arve fra `Drill`.
4. Hva skjer? Hvorfor?
 */

// Electric grill fungerer frem til den prøver å arve. 
public class ElectricDrill : Drill // Siden den arver fra en sealed class vil ikke dette fungere.
{
    
}

/*
Hva skjer? 
    - Klassen klarer ikke å arve, og man får beskjed om feil.
    - Det er fordi 'BaseKlassen' er sealed og dermed låst fra at noen andre klasser eller metoder påvirker den
    - eller rett og slett kan endre noe. 
*/
