namespace StockMarketCollector.Models;

public class StockExchange
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string ShortName { get; set; }
    public List<Stock> Stocks { get; set; } = [];
    public string? OpeningHour { get; set; }
    public string? ClosingHour { get; set; }
    public string? TimeZone { get; set; }
}