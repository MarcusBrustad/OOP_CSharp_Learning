namespace Abstraction;
/*
1. Lag en abstrakt klasse `Verktoy` som har:
    - En abstrakt metode `Bruk()`, som skal beskrive hvordan verktøyet brukes.
 */

// Lager en abstract klasse her. Er veldig likt som Interfaces, men vi kommer til det senere. 
public abstract class Verktoy
{
    // Deklarerer deler av klassen som må være med videre for bruk. 
    public abstract void Bruk();
}