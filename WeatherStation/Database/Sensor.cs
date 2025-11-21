using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Sensor
    {
        private static int counter;
        public int id { get; set; }
        public string Name { get; set; }
        public string Type  { get; set; }
        public string DateTime  { get; set; }
        public DateTime MeasurementDate  { get; set; }

        public Sensor()
        {
            counter++;
        }

    }
}
