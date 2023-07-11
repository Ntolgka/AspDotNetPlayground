using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetPlayground.Models
{
    public class ItemAndCategory
    {
        public int ItemCount { get; set; }
        public List<Item> Items { get; set; }
        public List<Category> Categories { get; set; }
    }
}