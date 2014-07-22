using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class Form1 : Form
    {
        Grade myGrade=new Grade();
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            myGrade.physics = Convert.ToDouble(pTextBox.Text);
            myGrade.chemistry = Convert.ToDouble(cTextBox.Text);
            myGrade.math = Convert.ToDouble(mTextBox.Text);
            avgTextBox.Text =Convert.ToString(myGrade.GetAverage());
            gradeTextBox.Text = myGrade.GetGradeLetter();


        }
    }
}
