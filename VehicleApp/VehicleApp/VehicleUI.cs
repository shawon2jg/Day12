using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;
        
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle(vehicleNameTextBox.Text,regNoTextBox.Text);
            vehicleNameTextBox.ReadOnly = true;
            regNoTextBox.ReadOnly = true;
            MessageBox.Show("Vehicle Account Created Successfully !!");
           
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.Speed = Convert.ToInt32(speedTextBox.Text);
            MessageBox.Show("Vehicle Speed is :" + aVehicle.Speed +"\nyou can Enter more Speed.");
            aVehicle.GetMinSpeed();
            aVehicle.GetAverage();
            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.MinSpeed.ToString();
            maxSpeedTextBox.Text = aVehicle.MaxSpeed.ToString();
            averageSpeedTextBox.Text = aVehicle.AvgSpeed.ToString();
           
        }
    }
}
