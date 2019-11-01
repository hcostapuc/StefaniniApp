using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppStefanini.Models;
namespace AppStefanini.Services
{
    class CitiesService : ICitiesService<CityColection>
    {

        public async Task<CityColection> GetCitiesAsync()
        {
            var citiesRepository = new Repository.CitiesRepository();
            return await Task.FromResult(citiesRepository.GetCities());
        }
    }
}
