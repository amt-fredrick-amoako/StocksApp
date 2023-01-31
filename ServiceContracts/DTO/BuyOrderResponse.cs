namespace ServiceContracts.DTO
{
    public class BuyOrderResponse
    {
        public Guid BuyOrderID { get; set; }
        public string StockSymbol { get; }
        public string StockName { get; set; }
        public DateTime DateAndTimeOfOrder { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TradeAmount { get; set; }
    }
}
