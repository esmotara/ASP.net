using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            aShop=new Shop();
            aShop.Name = nameTextBox.Text;
            aShop.Address = addressTextBox.Text;
            MessageBox.Show("Shop is created");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product aProduct=new Product();
            aProduct.ProductId = productTextBox.Text;
            aProduct.Quantity = Convert.ToInt16(quantityTextBox.Text);

            string show = aShop.AddProduct(aProduct);
            MessageBox.Show(show);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg = "Shop Name:" + " "+ aShop.Name + "\t "+ "Address:" +" " +aShop.Address + Environment.NewLine;
            msg += "Product Id" +"\t "+ "Quantity" +  Environment.NewLine;
            foreach (Product aProduct in aShop.productList)
            {

                msg += aProduct.ProductId +"\t "+ aProduct.Quantity  + Environment.NewLine;


            }

            MessageBox.Show(msg);
        }
    }
}
