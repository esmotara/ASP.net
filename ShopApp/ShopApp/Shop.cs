using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Product> productList = new List<Product>();
        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {

        }

        public string AddProduct(Product aProduct)
        {
         
            foreach (Product productObj in productList)
            {
                
                if (productObj.ProductId == aProduct.ProductId)
                {

                    productObj.Quantity += aProduct.Quantity;
                    return ("Product has been updated ");
                }
             
            }
            productList.Add(aProduct);
            return "Product has been added";

        }







        }
    }

