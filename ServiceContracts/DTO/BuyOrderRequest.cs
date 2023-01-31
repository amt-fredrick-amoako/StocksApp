using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class BuyOrderRequest
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
