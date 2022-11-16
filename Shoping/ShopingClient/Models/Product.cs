using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingClient.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Cagtegory { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
