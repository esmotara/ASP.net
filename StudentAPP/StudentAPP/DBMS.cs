using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentAPP
{
    class DBMS
    {
        public string AddDepartment(Dept aDepartment)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\StudentAPP\StudentAPP\Department.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertQuery = "INSERT INTO DepartmentTable(Code,Name) VALUES ('" + aDepartment.Code + "','" + aDepartment.Name + "')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Department Added";             
        }

        public string AddStudent(Student aStudent)
        {
            if (StudentExist(aStudent.RegNo))
            {
                UpdateStudent(aStudent);
                return "Student Updated";
            
            }
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\StudentAPP\StudentAPP\Department.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertQuery = "INSERT INTO StudentTable(RegNo,Name,Email) VALUES ('" + aStudent.RegNo + "','" + aStudent.StudentName + "','" + aStudent.Email + "')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Department Added";
        }


        public bool StudentExist(string regNo) 
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\StudentAPP\StudentAPP\Department.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertQuery = "SELECT RegNo FROM StudentTable WHERE RegNo = '" + regNo +"'";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                conn.Close();
                return true;
            }


            else
            { conn.Close();
            return false;
            }
        }

        public DataTable GetStudentTable(string table)
        {
            string query = "SELECT * FROM " + table;

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\StudentAPP\StudentAPP\Department.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConn.Close();
            return dt;
        }

        public string UpdateStudent(Student aStudent) 
        
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\acer\Desktop\StudentAPP\StudentAPP\Department.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertQuery = "UPDATE StudentTable SET Email='" + aStudent.Email + "' WHERE RegNo = '" + aStudent.RegNo + "'" ;
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Department Added"; 
        } 

    }
}
