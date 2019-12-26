using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Model.Entity
{
    public class Product
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public int stock { get; set; }
        public int price { get; set; }
        public string category { get; set; }
        public string supplier { get; set; }
    }
}
