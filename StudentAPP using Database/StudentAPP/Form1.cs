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
            DBMS newDBMS = new DBMS();
            string msg = newDBMS.AddDepartment(aDept);
            MessageBox.Show(msg);
            //aDept.studentList.Add();
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regTextBox.Text,studentNameTextBox.Text,emailTextBox.Text);
            //string show= aDept.AddStudent(aStudent);
            DBMS aDBMS = new DBMS();
            string msg = aDBMS.AddStudent(aStudent);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aDBMS.GetStudentTable("StudentTable");


            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            string msg = "Dept Id:" + aDept.Code + "Name:" + aDept.Name+Environment.NewLine;
            msg+= "Student Reg No" + "Name" + "Email"+Environment.NewLine;
            foreach (Student aStudent in aDept.studentList)
            {

               msg += aStudent.RegNo + aStudent.StudentName + aStudent.Email+Environment.NewLine;


            }
       
            MessageBox.Show(msg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.departmentDataSet.StudentTable);

        }


    }
}
