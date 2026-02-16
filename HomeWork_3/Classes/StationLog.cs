namespace HomeWork_3.Classes;

class StationLog:IDisposable
{
    private readonly StreamWriter _writer;

    public StationLog()
    {
        _writer = new StreamWriter("station.txt", true);
    }

    public void Write(string message)
    {
        _writer.WriteLine($"{message} - {DateTime.Now}");
        _writer.AutoFlush = true;
    }
    
    public void Dispose() => _writer.Dispose();
}
