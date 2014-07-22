using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;
        public double calculateHouseRent;
        public double calculateMedicalAllowance;
        public double total;

        public double GetSalary()
        {
            calculateHouseRent = (basicAmount*houseRent)/100;
            calculateMedicalAllowance = (basicAmount*medicalAllowance)/100;
            total = basicAmount + calculateHouseRent + calculateMedicalAllowance;
            return total;
        }
    }
}
