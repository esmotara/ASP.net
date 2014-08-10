using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class SellItem : Form
    {

        private Shop aShop;
        private Product aProduct;

        public SellItem()
        {
            InitializeComponent();
        }

       

        private void sellItemButton_Click(object sender, EventArgs e)
        {

            aProduct = new Product(sellProductIdTextBox.Text, Convert.ToInt16(sellQuantityTextBox.Text));
            //MessageBox.Show(aShopProduct.AddProduct(aProductInfo));
            ShopDatabase aDatabase = new ShopDatabase();
            //string msg = aDatabase.AddProduct(aProduct);

            //MessageBox.Show(msg);

            if (aDatabase.HasThisId(aProduct.ProductId))
            {
                if (aDatabase.HasQuantity(aProduct))
                {
                    MessageBox.Show(aDatabase.DeleteProductQuantity(aProduct)); 
                }
                
            }
            else
            {
                MessageBox.Show("Item not in stock");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aDatabase.GetProductTable("ProductTable");
        }
    }
}
