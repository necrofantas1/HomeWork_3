namespace HomeWork_3.Classes;
using Interface;

public class SolarPanel : IEnergySource
{
    public double GetOutput() => Random.Shared.Next(9, 101);
    
    public string EnergyType => "Solar";
}