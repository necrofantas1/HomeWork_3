namespace HomeWork_3.Classes;

class ScienceModule : StationModule
{
   List<string> ResearchProjects { get; set; }
   
    ScienceModule(string name, double energyConsumption) : base(name, energyConsumption)
    {
        ResearchProjects = new List<string>();
    }
    
    public override void PerformDiagnostics() => Console.WriteLine("Performing diagnostics");

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Prepearing microscopes");
    }
}