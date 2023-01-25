using Serilog;

namespace SeriLogConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Deneme 123");
            Log.Warning("Deneme 123");
            Log.Error("Ye");



            Console.WriteLine("Hello, World!");
        }
    }
}