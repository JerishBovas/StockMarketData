using System.ComponentModel.DataAnnotations;

namespace StockMarketData.Models;

public class Stock
{
    public int Id { get; set; }
    public required string Symbol { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public Company? Company { get; set; }
    public int StockExchangeId { get; set; }
    public StockExchange StockExchange { get; set; } = null!;
    public double LastDiv { get; set; }
    public string Range { get; set; } = "";
    public string Currency { get; set; } = "";
    public Quote? Quote { get; set; }
    public RealTimePrice? RealTimePrice { get; set; }
    public bool IsEtf { get; set; }
    public bool IsActivelyTrading { get; set; }
    public bool IsAdr { get; set; }
    public bool IsFund { get; set; }
}