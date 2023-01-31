using ModelValidationsExample.CustomValidators;
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

        [MinimumMonth(2000, ErrorMessage = "date and time of order shouldn't be older than Jan 01, {0}")]
        public DateTime DateAndTimeOfOrder { get; set; }

        [Range(1, 10000, ErrorMessage = "{0} should be set at ${1} minimum and ${2} maximum")]
        public int Quantity { get; set; }

        [Range(1, 10000, ErrorMessage = "{0} should be set at ${1} minimum and ${2} maximum")]
        public double Price { get; set; }
    }
}
