using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Product
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public Product(string productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public Product()
        {

        }



    }


}
