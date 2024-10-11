using Microsoft.EntityFrameworkCore;
using StockMarketCollector.Models;

namespace StockMarketCollector.Data
{
    public class StockMarketContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Stock> Stocks { get; init; }
        public DbSet<Company> Companies { get; init; }
        public DbSet<StockExchange> StockExchanges { get; init; }
        public DbSet<Quote> Quotes { get; init; }
        public DbSet<RealTimePrice> RealTimePrices { get; init;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
            .HasOne(e => e.Company)
            .WithOne(e => e.Stock)
            .HasForeignKey<Company>(e => e.StockId)
            .IsRequired();

            modelBuilder.Entity<Stock>()
            .HasOne(e => e.Quote)
            .WithOne(e => e.Stock)
            .HasForeignKey<Quote>(e => e.StockId)
            .IsRequired();

            modelBuilder.Entity<Stock>()
            .HasOne(e => e.RealTimePrice)
            .WithOne(e => e.Stock)
            .HasForeignKey<RealTimePrice>(e => e.StockId)
            .IsRequired();
        }

    }
}
