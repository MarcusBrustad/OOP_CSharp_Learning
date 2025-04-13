namespace Polymorphism;
/*
Ekstra: 
    1. Legg til en ny klasse: `RobotArm`, som også arver fra `Maskin`.
    2. Override `Start()` til å skrive:
        > "Robotarmen er klar til bruk."
 */
public class RobotArm : Maskin
{
    public override void Start()
    {
        Console.WriteLine("Robotarmen er klar til bruk.");
    }
}