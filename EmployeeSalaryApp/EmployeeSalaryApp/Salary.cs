using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public double BasicSalary { set; get; }
        public double Medical { set; get; }
        public double Conveyance { set; get; }

        public double noOfIncrements { get; private set; }

        public double GetTotal()
        {
            return BasicSalary + GetMedical() + GetConveyance();
            
        }

        public double GetConveyance()
        {
            return BasicSalary*(Conveyance/100);
        }

        public double GetMedical()
        {
            return BasicSalary*(Medical/100);
        }


        public void GetIncrese(double amount)
        {
            double basicAmount = (BasicSalary*amount)/100;
            BasicSalary += basicAmount;
            noOfIncrements ++;
        }
    }
}
