using System.ComponentModel.DataAnnotations;

namespace ServiceContracts.DTO
{
    public class SellOrderRequest
    {
        [Required]
        public string StocKSymbol { get; set; }

        [Required]
        public string StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }

        [Range(1, 10000)]
        public int Quantity { get; set; }

        [Range(1, 10000)]
        public double Price { get; set; }
    }
}
