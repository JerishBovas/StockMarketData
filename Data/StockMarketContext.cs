using Microsoft.EntityFrameworkCore;
using StockMarketData.Models;

namespace StockMarketData.Data
{
    public class StockMarketContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<RealTimePrice> RealTimePrices { get; set;}

        public StockMarketContext(DbContextOptions options) : base(options)
        {
        }

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
