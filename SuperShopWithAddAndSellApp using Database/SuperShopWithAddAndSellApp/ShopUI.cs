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
    public partial class ShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text, addressTextBox.Text);
            ShopDatabase aDatabase=new ShopDatabase();
            string msg = aDatabase.AddShop(aShop);

            MessageBox.Show(msg);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItem addItemForm = new AddItem();
            addItemForm.Show();
            

        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellItem sellListForm = new SellItem();
            sellListForm.Show();
        }





    }
}
