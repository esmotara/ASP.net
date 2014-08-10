using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPP
{
    class Student
    {
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public Student(string regNo, string studentName, string email)
        {
            RegNo = regNo;
            StudentName = studentName;
            Email = email;
        }

        public Student()
        {

        }
    }
}
