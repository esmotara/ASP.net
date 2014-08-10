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


        public Dictionary<string, Student> aDictionary= new Dictionary<string, Student>();
        public const int MAX_NO_OF_STUDENTS = 2;

        public Dept(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public Dept()
        {

        }

        public string AddStudent(Student studentObj)
        {

            if (aDictionary.Count < MAX_NO_OF_STUDENTS)
            {


                string reg = studentObj.RegNo;
                try
                {

                    aDictionary.Add(reg, studentObj);
                    return "Student has been saved in dept.";
                }
                catch (ArgumentException exceptionObj)
                {
                    return "student with the same name already exists.";
                }
            }

                
          

            else
            {
                return "Maximum no of students(" + MAX_NO_OF_STUDENTS +
                       ")has been saved. So, provided student information is not saved.";
            }

        }

        public Dictionary<string, Student> GetStudentList()
        {
            return aDictionary;
        }
    }
}
