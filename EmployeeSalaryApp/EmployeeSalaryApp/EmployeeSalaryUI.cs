using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private Employee anEmployee;
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.BasicSalary = Convert.ToDouble(basicEntryTextBox.Text);
            aSalary.Medical = Convert.ToDouble(medicalEntryTextBox.Text);
            aSalary.Conveyance = Convert.ToDouble(conveyanceEntryTextBox.Text);

            anEmployee = new Employee();
            anEmployee.Id = idTextBox.Text;
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;

            anEmployee.EmployeeSalary = aSalary;
        }

        private void showMeDetailsButton_Click(object sender, EventArgs e)
        {
            numberOfIncrementsTextBox.Text = anEmployee.EmployeeSalary.noOfIncrements.ToString();

            basicDetailsTextBox.Text = anEmployee.EmployeeSalary.BasicSalary.ToString();
            medicalDetailsTextBox.Text = anEmployee.EmployeeSalary.GetMedical().ToString();
            conveyanceDetailsTextBox.Text = anEmployee.EmployeeSalary.GetConveyance().ToString();
            totalTextBox.Text = anEmployee.EmployeeSalary.GetTotal().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            double incrementAmount = Convert.ToDouble(increaseTextBox.Text);
            anEmployee.EmployeeSalary.GetIncrese(incrementAmount);
        }
    }
}
