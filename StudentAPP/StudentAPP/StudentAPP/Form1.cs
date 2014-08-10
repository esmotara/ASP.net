using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAPP
{
    public partial class Form1 : Form
    {
        private Dept aDept;

       // private Student aStudent;
        public Form1()
        {
            InitializeComponent();
    
        }

      
        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            aDept = new Dept();
            aDept.Code = codeTextBox.Text;
            aDept.Name = nameTextBox.Text;
            //aDept.studentList.Add();
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regTextBox.Text,studentNameTextBox.Text,emailTextBox.Text);
            string show= aDept.AddStudent(aStudent);
            MessageBox.Show(show);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            string msg = "Dept Id:" + aDept.Code + "Name:" + aDept.Name+Environment.NewLine;
            msg+= "Student Reg No" + "Name" + "Email"+Environment.NewLine;
            foreach (KeyValuePair<string, Student> aStudent in aDept.GetStudentList())
            {

               msg += aStudent.Key + aStudent.Value.StudentName + aStudent.Value.Email+Environment.NewLine;


            }
       
            MessageBox.Show(msg);

        }


    }
}
