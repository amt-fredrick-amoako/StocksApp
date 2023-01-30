using ServiceContracts;

namespace Services
{
    public class FinnhubService : IFinnhubService
    {
        public Task<Dictionary<string, object>?> GetCompanyProfile(string stocksSymbol)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, object>?> GetStockPriceQuote(string stockSymbol)
        {
            throw new NotImplementedException();
        }
    }
}