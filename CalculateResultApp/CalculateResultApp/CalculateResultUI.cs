using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateResultApp
{
    public partial class CalculateResultUI : Form
    {
        public CalculateResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double physicsNum = Convert.ToDouble(physicsTextBox.Text);
            double chemistryNum = Convert.ToDouble(chemistryTextBox.Text);
            double mathNum = Convert.ToDouble(mathTextBox.Text);

            Student aStudent = new Student(physicsNum, chemistryNum, mathNum);

            averageTextBox.Text = aStudent.GiveAverage().ToString();
            gradeLetterTextBox.Text = aStudent.DetermineGrade();

            averageTextBox.Enabled = false;
            gradeLetterTextBox.Enabled = false;
        }
    }
}
