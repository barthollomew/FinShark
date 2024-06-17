using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        // DTO's are like a filter for our requests
        // Ask to return stock model WITHOUT the comments param
        // Copy and pasted and edited from Stock.cs

        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        // public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}