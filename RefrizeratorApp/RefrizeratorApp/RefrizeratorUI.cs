using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrizeratorApp
{
    public partial class RefrizeratorUI : Form
    {
        Refrizerator aRefrizerator=new Refrizerator();
        public RefrizeratorUI()
        {
            InitializeComponent();
        }

        private void saveCapacityButton_Click(object sender, EventArgs e)
        {
            aRefrizerator.Capacity = Convert.ToDouble(capacityTextBox.Text);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (aRefrizerator != null)
            {
                int noOfItems = Convert.ToInt16(itemsTextBox.Text);
                double weightPerItem = Convert.ToDouble(weightTextBox.Text);

               
                    try
                    {
                    
                        aRefrizerator.AddItems(noOfItems, weightPerItem);
                        currentWeightTextBox.Text = Convert.ToString(aRefrizerator.CurrentWeight);
                        remainingWeightTextBox.Text = Convert.ToString(aRefrizerator.RemainingWeight);
                    }
                    catch (Exception exceptionObj)
                    {
                        MessageBox.Show(exceptionObj.Message);
                    }
                }
            else
            {
                MessageBox.Show("Capacity is needed");
            }
        }
    }
}
