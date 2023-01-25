using Serilog;

namespace SeriLogConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.Seq(@"http://localhost:5341/")    // Burayı yazdığımızda Seq web sayfasında logları görebileceğiz
                .CreateLogger();

            Log.Information("Deneme 123");
            Log.Warning("Dikkat ...");
            Log.Error("Yetişin sistem patladı");

            Log.CloseAndFlush();

            Console.WriteLine("Hello, World!");
        }
    }
}