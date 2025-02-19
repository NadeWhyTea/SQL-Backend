using System;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        string connectionString = config.GetConnectionString("DefaultConnection");

        Console.WriteLine($"Retrieved Connection String: {connectionString}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}