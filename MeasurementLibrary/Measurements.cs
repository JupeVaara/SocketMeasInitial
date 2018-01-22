using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementLibrary
{
    public class Measurements
    {
        public double Time { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }

        public Measurements() { }

        public Measurements(string s)
        {
            string[] p = s.Split();
            Time = double.Parse(p[0]);
            Pressure = double.Parse(p[1]);
            Temperature = double.Parse(p[2]);
        }

        public Measurements(double time, double p, double t)
        {
            Time = time;
            Pressure = p;
            Temperature = t;
        }

        public override string ToString()
        {
            return Time + " " + Pressure + " " + Temperature;
        } 

    }
}
