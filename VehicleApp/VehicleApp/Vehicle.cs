using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string Name { set; private get; }
        public string RegNo { set; private get; }
        public double Speed { set; get; }
        public double MinSpeed { private set; get; }
        public double MaxSpeed { private set; get; }
        public double AvgSpeed { private set; get; }

        private double totalSpeed = 0;
        private double count = 0;
     


        public Vehicle(string name, string regNo):this()
        {
            this.Name = name;
            this.RegNo = regNo;
        }

        public Vehicle()
        {
            
        }
        public void GetMinSpeed()
        {
            if (MaxSpeed < Speed)
            {
                MaxSpeed = Speed;
            }
            else
            {
                MinSpeed = Speed;
            }
        }
        
        
        public void GetAverage()
        {
            totalSpeed += Speed;
            count++;
            AvgSpeed = totalSpeed/count;
        }
    }
}
