using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
    interface ITemperature
    {
        double TemperatureMax { get; set; }
        double TemperatureMin { get; set; }
        double TemperatureNow { get; set; }
    }
}
