using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
    public class Temperature : ITemperature
    {
        public double TemperatureMax { get; set; }
        public double TemperatureMin { get; set; }
        public double TemperatureNow { get; set; }
    }
}
