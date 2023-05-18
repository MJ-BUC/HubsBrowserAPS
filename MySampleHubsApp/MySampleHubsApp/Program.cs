using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

// This code will make sure that the .NET application creates a web server with our new Startup class.

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}