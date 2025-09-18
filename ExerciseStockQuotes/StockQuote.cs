// this file is out of scope for the code review exercise
namespace ExerciseStockQuotes.Controllers
{
  public class StockQuote
  {
    public required string TickerName { get; set; }
    public decimal Value { get; set; }
    
    public bool Ipo { get; set; }
  }
}