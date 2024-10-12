using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace StockMarketCollector.Data;

public class StockMarketContextDesignFactory : IDesignTimeDbContextFactory<StockMarketContext>
{
    public StockMarketContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddUserSecrets<Program>()
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<StockMarketContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new StockMarketContext(optionsBuilder.Options);
    }
}