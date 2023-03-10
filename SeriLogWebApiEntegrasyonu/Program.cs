
using Serilog;

namespace SerilogWebApiEntegrasyonu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                   .WriteTo.Console()
                   .WriteTo.Seq(@"http://localhost:5341/")
                   .CreateLogger();

            try
            {
                Log.Information("Starting web aplication");

                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.

                builder.Host.UseSerilog();
                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.UseSerilogRequestLogging(); // Add this line

                app.MapControllers();


                app.Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}