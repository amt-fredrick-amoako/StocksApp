namespace ServiceContracts
{
    public interface IFinnhubService
    {
        Task<Dictionary<string, object>?> GetCompanyProfile(string stocksSymbol);

        Task<Dictionary<string, object>?> GetStockPriceQuote(string stockSymbol);



    }
}