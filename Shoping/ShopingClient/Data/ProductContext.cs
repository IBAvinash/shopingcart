using ShopingClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingClient.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product(){
                Name="Demo Data",
                Description="This data for Demo",
                ImageFile="Product.png",
                Cagtegory="Demo",
                Price=5000

            }
        }; 
    }
}
