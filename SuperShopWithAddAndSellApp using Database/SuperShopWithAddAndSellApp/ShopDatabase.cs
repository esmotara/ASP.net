using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.SqlClient;

namespace SuperShopWithAddAndSellApp
{
    class ShopDatabase
    {

        private string connectionString;
        public ShopDatabase()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }
     
       //string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public string AddShop(Shop aShop)
        {
            //string connectionString =
            // @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO ShopTable(Name,Address) VALUES ('" + aShop.ShopName + "','" +
                           aShop.ShopAddress + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Shop has been saved.";
        }

        public string AddProduct(Product aProduct)
        {
           // string connectionString =
           //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO ProductTable(ProductID,Quantity) VALUES ('" + aProduct.ProductId + "','" +
                           aProduct.Quantity + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Product has been saved.";
        }


        public string UpdateProductQuantity(Product aProduct)
        {
           // string connectionString =
           //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE ProductTable SET Quantity = Quantity + " + aProduct.Quantity + " WHERE ProductID = '" + aProduct.ProductId + "'";
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            return "Product has been saved.";
        }

        public bool HasThisId(string productId)
        {
          //  string connectionString =
          //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT ProductId FROM ProductTable WHERE ProductId = '" + productId + "'";
            SqlCommand insert = new SqlCommand(query, conn);
            SqlDataReader productReader = insert.ExecuteReader();

            if (productReader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

            
        }

        public DataTable GetProductTable(string table)
        {

            //string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            string query = "Select * from " + table;
            SqlConnection aSqlConnection =new SqlConnection(connectionString);
            aSqlConnection.Open();
            SqlCommand aSqlCommand=new SqlCommand(query,aSqlConnection);
            DataTable aDataTable=new DataTable();
            aDataTable.Load(aSqlCommand.ExecuteReader());
            aSqlConnection.Close();
            return aDataTable;
        }
        public string DeleteProductQuantity(Product aProduct)
        {
           // string connectionString =
            //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE ProductTable SET Quantity = Quantity - " + aProduct.Quantity + " WHERE ProductID = '" + aProduct.ProductId + "'";
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            return "Product has been sold.";
        }

        public bool HasQuantity(Product productObj)
        {
            //string connectionString =
            //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\10.08.14\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Shop.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM ProductTable WHERE ProductId = '" + productObj.ProductId + "' AND Quantity >= " + productObj.Quantity;
            SqlCommand insert = new SqlCommand(query, conn);


            SqlDataReader productReader = insert.ExecuteReader();

            if (productReader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

    }
}
