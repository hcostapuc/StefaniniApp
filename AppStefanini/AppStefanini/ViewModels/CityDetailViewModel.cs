
using AppStefanini.Models;
using AppStefanini.Services;
using Xamarin.Forms;

namespace AppStefanini.ViewModels
{
    public class CityDetailViewModel : BaseViewModel
    {
        IWeatherOpenService WeatherOpenService => DependencyService.Get<IWeatherOpenService>() ?? new WeatherOpenService();

        public City City { get; set; }
        private Temperature _temperature;
        public Temperature Temperature { get { return _temperature; } set { SetProperty(ref _temperature, value); } }
        
        public CityDetailViewModel(City city = null)
        {
            City = city;
            GetTemperatureAsync();
        }
        private async void GetTemperatureAsync()
        {
            Temperature = await WeatherOpenService.GetTemperatureAsync(City.Id).ConfigureAwait(false);
        }
    }
}
