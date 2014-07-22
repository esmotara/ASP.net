using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    class Grade
    {
        public double physics;
        public double chemistry;
        public double math;
        public double average;
        public string gradeLetter;

        public double GetAverage()
        {
            average = (physics + chemistry + math)/3;
            return average;
        }
        public string GetGradeLetter()
        {

           if (average >= 80)
            {
                gradeLetter = "A+";
                return gradeLetter;
            }

            else if(average>=70)
            {
                gradeLetter = "B+";
                return gradeLetter;
            }

            else if (average >= 60)
            {
                gradeLetter = "C+";
                return gradeLetter;
            }

            else if (average >= 50)
            {
                gradeLetter = "D+";
                return gradeLetter;
            }

            else 
            {
                gradeLetter = "F";
                return gradeLetter;
            }

            
        }
    }
}
