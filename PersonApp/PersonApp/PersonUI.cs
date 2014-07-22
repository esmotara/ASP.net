using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        private Person aPerson; 
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showFullNameButton_Click(object sender, EventArgs e)
        {
           
            SetNames();
            MessageBox.Show(aPerson.GetFullName());
        }

        private void SetNames()
        {
            aPerson = new Person(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text);

        }

        private void ameButton_Click(object sender, EventArgs e)
        {
            SetNames();
            MessageBox.Show(aPerson.GetReverseName());
        }
    }
}
