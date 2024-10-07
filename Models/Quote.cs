namespace StockMarketData.Models;

public class Quote
{
    public int Id { get; set; }
    public double Price { get; set; }
    public double ChangesPercentage { get; set; }
    public double Change { get; set; }
    public double DayLow { get; set; }
    public double DayHigh { get; set; }
    public double YearHigh { get; set; }
    public double YearLow { get; set; }
    public long MarketCap { get; set; }
    public double PriceAvg50 { get; set; }
    public double PriceAvg200 { get; set; }
    public long Volume { get; set; }
    public long AvgVolume { get; set; }
    public double Open { get; set; }
    public double PreviousClose { get; set; }
    public double Eps { get; set; }
    public double Pe { get; set; }
    public DateTime EarningsAnnouncement { get; set; }
    public long SharesOutstanding { get; set; }
    public long Timestamp { get; set; }
    public int StockId { get; set; }
    public Stock Stock { get; set; } = null!;
}