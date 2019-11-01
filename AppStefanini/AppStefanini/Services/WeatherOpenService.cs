using AppStefanini.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppStefanini.Services
{
    public class WeatherOpenService : IWeatherOpenService
    {
        private HttpClient httpClient { get; set; }
        private string BaseUrlApiOpenWeather { get { return "http://api.openweathermap.org/data/2.5/weather?"; } }
        private string KeyApiOpenWeather { get { return "2bac87e0cb16557bff7d4ebcbaa89d2f"; } }
        public WeatherOpenService()
        {
            httpClient = new HttpClient() { BaseAddress = new Uri(BaseUrlApiOpenWeather) };
            httpClient.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("x-api-key", KeyApiOpenWeather);
        }
        /// <summary>
        /// Get the temperature async info by id of the city
        /// </summary>
        /// <param name="idCity"></param>
        /// <returns></returns>
        public async Task<Temperature> GetTemperatureAsync(long idCity)
        {

            var uri = new Uri(string.Concat(httpClient.BaseAddress, "id=", idCity,"&APPID=",KeyApiOpenWeather));
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(content);
                return await Task.FromResult(new Temperature() { TemperatureNow = result.main.temp, TemperatureMin = result.main.temp_min, TemperatureMax = result.main.temp_max });
            }
            else
                throw new Exception(response.ReasonPhrase);
        }

    }
}
