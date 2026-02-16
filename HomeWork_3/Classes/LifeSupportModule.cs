namespace HomeWork_3.Classes;

class LifeSupportModule : StationModule
{
    int OxygenLevel { get; set; }
    
    public LifeSupportModule(string name, double energyConsumption, int oxygenLevel) : base(name, energyConsumption)
    { 
        OxygenLevel = oxygenLevel;
    }

    public override void PerformDiagnostics()
    {
        Console.WriteLine("Performing diagnostics");
        Console.WriteLine($"Oxygen level: {OxygenLevel}");
    }
    
}