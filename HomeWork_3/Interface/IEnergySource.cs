namespace HomeWork_3.Interface;

public interface IEnergySource
{
    public double GetOutput();
    
    string EnergyType { get; }
}