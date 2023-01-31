using ModelValidationsExample.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class SellOrder
    {
        public Guid SellOrderID { get; set; }

        [Required]
        public string StockSymbol { get; set; }

        [Required]
        public string StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }

        [Range(1, 1000, ErrorMessage = "{0} should be set at ${1} minimum and ${2} maximum")]
        public int Quantity { get; set; }

        [Range(1, 1000, ErrorMessage = "{0} should be set at ${1} minimum and ${2} maximum")]
        public double Price { get; set; }
    }
}
