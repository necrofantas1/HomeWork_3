using HomeWork_3.Classes;

namespace HomeWork_3;

class Program
{
    static void Main(string[] args)
    {
        using var log = new StationLog();
        
        for (long i = 0; i < 10000000; i++)
        {
            Console.WriteLine(i);
            if (i % 10000 == 0) log.Write(i.ToString());
        }
        
        Console.ReadLine();
    }
    
}