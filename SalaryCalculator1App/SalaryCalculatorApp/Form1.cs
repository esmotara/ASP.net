using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        SalaryCalculator mySalaryCalculator=new SalaryCalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            mySalaryCalculator.employeeName = nameTextBox.Text;
            mySalaryCalculator.basicAmount = Convert.ToDouble(amountTextBox.Text);
            mySalaryCalculator.houseRent = Convert.ToDouble(houseTextBox.Text);
            mySalaryCalculator.medicalAllowance = Convert.ToDouble(medicalTextBox.Text);
            MessageBox.Show(mySalaryCalculator.employeeName +","+ "Your salary is:" + " " + mySalaryCalculator.GetSalary()+ ","+" your house rent is:"+ mySalaryCalculator.houseRent + " and "+" your medical allowance is:"+ mySalaryCalculator.medicalAllowance);
        }
    }
}
