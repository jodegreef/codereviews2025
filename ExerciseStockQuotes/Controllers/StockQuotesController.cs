using Microsoft.AspNetCore.Mvc;

namespace ExerciseStockQuotes.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class StockQuotesController : ControllerBase
  {
    public StockQuotesController()
    {
    }

    [HttpGet]
    public async Task<IEnumerable<StockQuote>?> GetIpoStockQuotes()
    {
      HttpClient client = new HttpClient();
      var response = await client.GetFromJsonAsync<StockQuote[]>(Constants.StockQuoteServer) ?? Array.Empty<StockQuote>(); ;

      var filteredValues = response.Where(x => x.Ipo).ToList();

      return filteredValues;
    }
  }
}
