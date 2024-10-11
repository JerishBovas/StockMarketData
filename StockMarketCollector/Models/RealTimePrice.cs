namespace StockMarketCollector.Models;

public class RealTimePrice
{
    public int Id { get; set; }
    public double BidSize { get; set; }
    public double AskSize { get; set; }
    public double BidPrice { get; set; }
    public double AskPrice { get; set; }
    public double Volume { get; set; }
    public double LastSalePrice { get; set; }
    public double LastSaleSize { get; set; }
    public DateTime LastSaleTime { get; set; }
    public double FmpLast { get; set; }
    public DateTime LastUpdated { get; set; }
    public int StockId { get; set; }
    public Stock Stock { get; set; } = null!;
}