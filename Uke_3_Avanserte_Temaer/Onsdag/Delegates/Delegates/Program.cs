namespace Delegates;

/*
- **🧩 Oppgave 1: Enkel delegate-bruk**
    1. Lag en delegate-type `Logger` som tar inn en `string`.
    2. Lag en metode `LogToConsole(string message)` som skriver ut meldingen.
    3. Lag en delegate-variabel og pek den til `LogToConsole`.
    4. Kall den via delegaten med `"Dette er en testlogg"`.
- **🔧 Oppgave 2: Send metode som argument**
    1. Lag en metode `RunLogger(Logger logger)`, som kaller `logger("Starter logging...")`.
    2. Lag en ny metode `LogToFile(string message)` som bare skriver `"Simulert logging til fil: <melding>"`.
    3. Kall `RunLogger()` med både `LogToConsole` og `LogToFile`.
    
- **💡 Ekstra utfordring (med variasjon!)**
    1. Lag en delegate `VehicleServiceHandler` som tar inn en `Vehicle`instans.
    2. Lag en klasse `Vehicle` med `Name` og `Mileage`.
    3. Lag to metoder:
        - `ServiceOil(Vehicle v)` → `"Oljeservice for {v.Name}"`
        - `ServiceTires(Vehicle v)` → `"Dekksjekk for {v.Name}"`
    4. Lag en metode `PerformService(Vehicle v, VehicleServiceHandler handler)`
    5. Kall `PerformService()` med ulike handler-metoder, og bruk en liste av kjøretøy med en `foreach`.
    
 */
class Program
{
    //  1.1. Lag en delegate-type `Logger` som tar inn en `string`.
    private delegate void Logger(string logMessage);

    // E.1. Lag en delegate `VehicleServiceHandler` som tar inn en `Vehicle`instans.
    private delegate void VehicleServiceHandler(Vehicle vehicle);
    
    
    static void Main(string[] args)
    {
        // 1.3. Lag en delegate-variabel og pek den til `LogToConsole`.
        Logger consoleLogger = LogToConsole;
        // 1.4. Kall den via delegaten med `"Dette er en testlogg"`.
        //consoleLogger("Dette er en testlogg");
        Logger fileLogger = LogToFile;
        //fileLogger("Dette er en testlogg");
        Logger comboLogger = consoleLogger +  fileLogger;
        // 2.3. Kall `RunLogger()` med både `LogToConsole` og `LogToFile`.
        //RunLogger(comboLogger);
        
        // E.5. Kall `PerformService()` med ulike handler-metoder, og bruk en liste av kjøretøy med en `foreach`.
        Vehicle car = new Vehicle()
        {
            Name = "Car",
            Mileage = 267900
        };

        List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle() { Name = "Car", Mileage = 123400 },
            new Vehicle() { Name = "Truck", Mileage = 2345600 },
            new Vehicle() { Name = "Plane", Mileage = 999999 },
            new Vehicle() { Name = "Bike", Mileage = 2345600 },
            new Vehicle() { Name = "MotorBike", Mileage = 2345600 },
            new Vehicle() { Name = "Boat", Mileage = 2345600 },
        };

        int i = 0;
        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle.Name == "Boat")
            {
                Console.WriteLine($"The {vehicle.Name} is on the ocean and we will try an oil change. No tires here.");
                continue;
            }
            if (i % 2 == 0 || vehicle.Name == "Plane")
            {
                PerformService(vehicle, ServiceOil);
            }
            else
            {
                PerformService(vehicle, ServiceTires);
            }
            i += 1;
        }

    }
    
    //------------------------------------------------------------------------------------------------------------//

    
    // 1.2. Lag en metode `LogToConsole(string message)` som skriver ut meldingen.
    private static void LogToConsole(string logMessage) => Console.WriteLine($"Logging til console: {logMessage}");
    
    // 2.1. Lag en metode `RunLogger(Logger logger)`, som kaller `logger("Starter logging...")`.
    private static void RunLogger(Logger logger)
    {
        logger("Starter Logging ...");
    }
    
    // 2.2. Lag en ny metode `LogToFile(string message)` som bare skriver `"Simulert logging til fil: <melding>"`.
    private static void LogToFile(string message) => Console.WriteLine($"Simulert logging til fil: <{message}>");
    
    //------------------------------------------------------------------------------------------------------------//

    // E.3. Lag to metoder:
    //- `ServiceOil(Vehicle v)` → `"Oljeservice for {v.Name}"`
    //- `ServiceTires(Vehicle v)` → `"Dekksjekk for {v.Name}"`

    private static void ServiceOil(Vehicle v) => Console.WriteLine($"Oljeservice for {v.Name}");
    
    private static void ServiceTires(Vehicle v) => Console.WriteLine($"Dekksjekk for {v.Name}");
    
    
    // E.4. Lag en metode `PerformService(Vehicle v, VehicleServiceHandler handler)`
    private static void PerformService(Vehicle v, VehicleServiceHandler handler)
    {
        handler(v);
    }

}