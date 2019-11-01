using AppStefanini.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStefanini.Services
{
    interface IWeatherOpenService
    {
        Task<Temperature> GetTemperatureAsync(long idCity);
    }
}
