using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MeasurementLibrary;

namespace Server
{
    

    class Simulator
    {
        private Random gen = new Random();
        Measurements measurement;
        double time = 1;

        public Measurements Read()
        {
            time += 1.0;
            measurement = new Measurements();
            measurement.Time = time;
            measurement.Temperature = 10 + 5 * Math.Cos(time / 5.0) +
                gen.NextDouble();
            measurement.Pressure = 10 * Math.Sin(time) +
                gen.NextDouble() * 2;

            return measurement;
        }
    }


}
