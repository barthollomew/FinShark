using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api
{
    public class Comment
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Foreign Key: Need to associate each comment with a (parent) stock
        public int? StockId { get; set; }

        // Navigation Property: Since nav property is setup (Entity ORM automatically links it), we can access parent stock object from child comment
        public Stock? Stock { get; set; }
    }
}