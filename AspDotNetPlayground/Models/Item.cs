using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetPlayground.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public bool IsOnSale { get; set; }

    }
}