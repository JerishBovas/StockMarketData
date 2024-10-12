using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace StockMarketCollector.Models;

[Index(nameof(Symbol), IsUnique = true)]
public class Stock
{
    public int Id { get; init; }
    public required string Symbol { get; init; }
    public string? Name { get; init; }
    public double? Price { get; init; }
    public Company? Company { get; init; }
    public int StockExchangeId { get; init; }
    public StockExchange StockExchange { get; init; } = null!; 
    public double LastDiv { get; init; }
    public string Range { get; init; } = "";
    public string Currency { get; init; } = "";
    public Quote? Quote { get; init; }
    public RealTimePrice? RealTimePrice { get; init; }
    public bool IsEtf { get; init; }
    public bool IsActivelyTrading { get; init; }
    public bool IsAdr { get; init; }
    public bool IsFund { get; init; }
}