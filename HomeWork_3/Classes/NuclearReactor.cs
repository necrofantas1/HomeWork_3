namespace HomeWork_3.Classes;
using Interface;

public class NuclearReactor : IEnergySource
{
    private const double NuclearEnergy = 1000;
    
    public double GetOutput() => NuclearEnergy;
    
    public string EnergyType => "Nuclear";
}