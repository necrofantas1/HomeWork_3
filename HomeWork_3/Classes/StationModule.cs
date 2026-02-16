namespace HomeWork_3.Classes;

abstract class StationModule
{
    private double _energyConsumption;

    public string Name { get; init; }

    public bool IsRunning { get; set; }

    public StationModule(string name, double energyConsumption)
    {
        Name = name;
        _energyConsumption = energyConsumption;
    }
    public abstract void PerformDiagnostics();

    virtual public void Start()
    {
        IsRunning = true;
    }
    
}

