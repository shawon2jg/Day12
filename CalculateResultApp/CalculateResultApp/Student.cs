using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateResultApp
{
    class Student
    {
        public double PhysicsNum { set; get; }
        public double ChemistryNum { set; get; }
        public double MathNum { set; get; }
        private double average = 0;
        private string grade;

        public Student(double physicsNum, double chemistryNum, double mathNum) : this()
        {
            PhysicsNum = physicsNum;
            ChemistryNum = chemistryNum;
            MathNum = mathNum;
        }

        public Student()
        {
            
        }

        public double GiveAverage()
        {
            return (PhysicsNum + ChemistryNum + MathNum)/3;
        }

        public string DetermineGrade()
        {
            average = GiveAverage();
            if (average >= 80)
            {
                grade = "A+";
            }
            else if (average >= 70)
            {
                grade = "B+";
            }
            else if (average >= 60)
            {
                grade = "C+";
            }
            else if (average >= 50)
            {
                grade = "D+";
            }
            else
            {
                grade = "F";
            }
            return grade;
        }
    }
}
