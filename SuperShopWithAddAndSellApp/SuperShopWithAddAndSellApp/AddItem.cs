using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class AddItem : Form
    {
        private Shop aShop;
        private Product aProduct;
        public AddItem()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProduct= new Product(productIdTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            //MessageBox.Show(aShopProduct.AddProduct(aProductInfo));
            ShopDatabase aDatabase = new ShopDatabase();
            //string msg = aDatabase.AddProduct(aProduct);

            //MessageBox.Show(msg);

            if (aDatabase.HasThisId(aProduct.ProductId))
            {
                MessageBox.Show(aDatabase.UpdateProductQuantity(aProduct));
            }
            else
            {
                MessageBox.Show(aDatabase.AddProduct(aProduct));
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aDatabase.GetProductTable("ProductTable");

        }

        
    }
}
