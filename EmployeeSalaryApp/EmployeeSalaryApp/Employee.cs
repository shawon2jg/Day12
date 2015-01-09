using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string Id { set; private get; }
        public string Name { set; private get; }
        public string Email { set; private get; }

        public Salary EmployeeSalary { set; get; }




    }
}
