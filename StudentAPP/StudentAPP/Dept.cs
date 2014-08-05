using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPP
{
    internal class Dept
    {
        public string Code { get; set; }
        public string Name { get; set; }


        public List<Student> studentList = new List<Student>();
        public const int MAX_NO_OF_STUDENTS = 2;

        public Dept(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public Dept()
        {

        }

        public string AddStudent(Student aStudent)
        {

            if (studentList.Count < MAX_NO_OF_STUDENTS)
            {
                foreach (Student studentObj in studentList)
                {
                    if (studentObj.RegNo == aStudent.RegNo)
                        return "already exists";
                }
                
                        studentList.Add(aStudent);
                        return "Student has been saved in dept.";
                    }

                
          

            else
            {
                return "Maximum no of students(" + MAX_NO_OF_STUDENTS +
                       ")has been saved. So, provided student information is not saved.";
            }

        }


    }
}
